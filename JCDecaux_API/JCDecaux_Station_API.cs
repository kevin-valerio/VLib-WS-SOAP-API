using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace JCDecaux_API {
    /// <summary>
    /// This class implements the JCDecaux API in order to get all informations about Velibs of a specific city.
    /// Note : this class also implements the Singleton design pattern.
    /// </summary>

    public class JCDecaux_Stations_API {
        private String API_KEY;
        private String CITY;
        private String URL = "https://api.jcdecaux.com/vls/v1/stations?contract={{VILLE}}&apiKey={{API_KEY}}";
        public List<Station> Stations { get; set; }


        //Unique instance
        private static JCDecaux_Stations_API API_Instance = null;
        private static readonly object padlock = new object();

        //Constructor. Setting new API key
        public JCDecaux_Stations_API(String API_KEY) {
            setAPI(API_KEY);
        }

        //Get instance of singleton
        public static JCDecaux_Stations_API getInstance {
            get {
                lock (padlock) {
                    if (API_Instance == null) {
                        API_Instance = new JCDecaux_Stations_API();
                    }
                    return API_Instance;
                }
            }
        }
        //Default constructor for singleton pattern
        JCDecaux_Stations_API() {
        }

        //Constructor. Setting new API key and city if needed
        public JCDecaux_Stations_API(String API_KEY, String city) {
            setAPI(API_KEY);
            setCity(city);
        }

        //Setting new URL with city
        public void setCity(String city) {

            if (city.Equals("")) {
                URL = URL.Replace("contract={{VILLE}}&", city);                
            }
            else {
              URL = URL.Replace("{{VILLE}}", city);
            }
            if(CITY != null && !CITY.Equals("")) {
                URL = URL.Replace(CITY, city); //In case of new city
            }
            CITY = city;


        }

        //Setting new URL with API key
        public void setAPI(String API) {
            API_KEY = API;
            URL = URL.Replace("{{API_KEY}}", API);
        }

        public static DateTime timestampToDate(double javaTimeStamp) {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public void feedStations() {
            try {
                WebResponse response = WebRequest.Create(URL).GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Stations = JsonConvert.DeserializeObject<List<Station>>(reader.ReadToEnd());
                reader.Close();
                response.Close();
            } catch (JsonSerializationException e2) {
                //do nothing, it's usually an ok-errorr
            }catch (Exception e) {
                throw e;
            }
           
        }
    }
}