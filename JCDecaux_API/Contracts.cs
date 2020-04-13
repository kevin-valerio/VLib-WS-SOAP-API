using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCDecaux_API {
     
    public class Contract {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("commercial_name")]
        public string CommercialName { get; set; }

       [JsonProperty("cities")]
        public List<String> Cities { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }


    }

}
