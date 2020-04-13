using JCDecaux_API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VLib_Client.VLibSoapService;
using Station = VLib_Client.VLibSoapService.Station;
using Contract = VLib_Client.VLibSoapService.Contract;

namespace VLib_Client {
    class RESTClient {

        private bool isFullFeed= false;
        public RESTClient() {
            if (fullFeed()) {
                isFullFeed = true;
            }
        }

        private const String __BASE_URL__ = "http://localhost:8733/Design_Time_Addresses/VLibAPI/SOAP/";
        public Station[] getAllStationsIn(string city) {
            if (isFullFeed) {
                WebResponse response = WebRequest.Create(__BASE_URL__ + "getAllStationsIn?city=" + city).GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                return JsonConvert.DeserializeObject<Station[]>(reader.ReadToEnd());
            }
            throw new Exception("Feed isn't complete.");
        }

        public Step[] getInstructions(bool isPedestrian, String srcAddress, String destAddres){
            if (isFullFeed) {
                WebResponse response = WebRequest.Create(__BASE_URL__ + "getInstructions?isPedestrian=" + isPedestrian
                    + "&srcAddress=" + srcAddress + "&destAddres=" + destAddres).GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                return JsonConvert.DeserializeObject<Step[]>(reader.ReadToEnd());
            }
            throw new Exception("Feed isn't complete.");
        }

        public bool fullFeed() {
            return (new StreamReader(WebRequest.Create(__BASE_URL__ + "fullFeed").GetResponse().GetResponseStream()).ReadToEnd().Equals("true"));
        }

        public Station getStationByName(String name) {

            if(isFullFeed) {
                WebResponse response = WebRequest.Create(__BASE_URL__ + "getStationByName?name=" + name).GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                return JsonConvert.DeserializeObject<Station>(reader.ReadToEnd());
            }
            throw new Exception("Feed isn't complete.");
           
        }
    }
}
