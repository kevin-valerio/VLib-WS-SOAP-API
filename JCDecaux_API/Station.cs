using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCDecaux_API {
    public class Position {

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }

        public override string ToString() {
            return Longitude + ", " + Latitude;
        }
    } 

    public class Station {

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("contract_name")]
        public string City { get; set; }

        [JsonProperty("name")]
        public string StationName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("banking")]
        public bool Banking { get; set; }

        [JsonProperty("bonus")]
        public bool Bonus { get; set; }

        [JsonProperty("bike_stands")]
        public int TotalSpace { get; set; }

        [JsonProperty("available_bike_stands")]
        public int FreeSpace { get; set; }

        [JsonProperty("available_bikes")]
        public int AvailableBikes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("last_update")]
        public long LastUpdate { set; get; } 
         
       

    }

}
