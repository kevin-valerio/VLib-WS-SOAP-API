using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using JCDecaux_API;

namespace JCDecaux_API {
    /// <summary>
    /// This class implements the JCDecaux API in order to get all informations about cities and contracts
    /// Note : this class also implements the Singleton design pattern.
    /// </summary>

    public class JCDecaux_Contracts_API {
        private String API_KEY;
        private String URL = "https://api.jcdecaux.com/vls/v1/contracts?apiKey={{API_KEY}}";
        public List<Contract> Contracts { get; set; }


        //Unique instance
        private static JCDecaux_Contracts_API API_Instance = null;
        private static readonly object padlock = new object();

        //Constructor. Setting new API key
        public JCDecaux_Contracts_API(String API_KEY) {
            setAPI(API_KEY);
        }

        //Get instance of singleton
        public static JCDecaux_Contracts_API getInstance {
            get {
                lock (padlock) {
                    if (API_Instance == null) {
                        API_Instance = new JCDecaux_Contracts_API();
                    }
                    return API_Instance;
                }
            }
        }

        JCDecaux_Contracts_API() {
        } 

        //Setting new URL with API key
        public void setAPI(String API) {
            API_KEY = API;
            URL = URL.Replace("{{API_KEY}}", API);
        }
         

        public void feedContracts() {
            WebResponse response = WebRequest.Create(URL).GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Contracts = JsonConvert.DeserializeObject<List<Contract>>(reader.ReadToEnd()); 
            reader.Close();
            response.Close(); 
        }
    }
}