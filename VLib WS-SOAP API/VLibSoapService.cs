using JCDecaux_API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace VLib_WSSOAP_API {
    public class VLibSoapService : IVLibSoapService {
        private const string API_KEY = "8542dbcf60bced995bb88e18829cc836c7ec5afe";
        private const string GOOGLEMAP_API_KEY = "AIzaSyDlI8dnQaDznecsNqhcYX8H10UomR1NPco";


        /// <param name="doFeed"> If set to true, don't need to call fullFeed() to get all stations and contracts data</param>
        public VLibSoapService(bool doFeed) {
            if (doFeed) fullFeed();
        }

        public VLibSoapService() {
        }

        /// <summary>This method feed all the variable, so you can work with it.</summary>
        public bool fullFeed() {

            try {
                JCDecaux_Contracts_API.getInstance.setAPI(API_KEY);
                JCDecaux_Stations_API.getInstance.setAPI(API_KEY);
                JCDecaux_Stations_API.getInstance.setCity(""); //no city, we want everything

                JCDecaux_Stations_API.getInstance.feedStations();
                JCDecaux_Contracts_API.getInstance.feedContracts();
            } catch (Exception error) {
                //Returning false if we got any kind of error.
                return false;
            }
            return true;
        }


        /*This is the caching system. We get all the data one for all, and store it into our JCDecaux instance. 
        Then we just need to call the following method in order to get data, 
        so the real JCDecaux servers won't be "spammed" of requests.*/


        /// <summary>Get all contracts</summary>

        List<Contract> IVLibSoapService.getContracts() {
            return JCDecaux_Contracts_API.getInstance.Contracts;
        }

        /// <summary>Get all stations</summary>
        List<Station> IVLibSoapService.getStations() {
            return JCDecaux_Stations_API.getInstance.Stations;
        }
        /// <summary>Return a list of Stations located in a given city</summary>
        /// <param name="city">The city to get the stations in</param>
        List<Station> IVLibSoapService.getAllStationsIn(string city) {
            List<Station> stations = new List<Station>();
            foreach (Station station in JCDecaux_Stations_API.getInstance.Stations) {
                if (station.City.Contains(city)) {
                    stations.Add(station);
                }
            }
            return stations;
        }


        private Direction getDirection(bool isPedestrian, string srcAddress, string destAddress) {

            String mode = isPedestrian ? "walking" : "bicycling";
            String FULL_GMAP_URL = "https://maps.googleapis.com/maps/api/directions/json?origin=" + srcAddress
                + "&destination=" + destAddress + "&mode=" + mode + "&key=" + GOOGLEMAP_API_KEY;

           
            var json = new WebClient().DownloadString(FULL_GMAP_URL);
            return JsonConvert.DeserializeObject<Direction>(json);
        }

        /// <summary>Return a static image of the direction from an address to another</summary>
        /// <param name="isPedestrian">Should we use pedestrian algorithm or bike algorithm</param>
        /// <param name="srcAddress">Source address</param>
        /// <param name="destAddres">Destination address</param>
        Bitmap IVLibSoapService.getStaticMapImage(bool isPedestrian,
            string srcAddress, string destAddres, bool ignoreException) {

            String size = "432x202";
            String path = getDirection(isPedestrian, srcAddress, destAddres).routes[0].overview_polyline.points;
            String firstMarkerSrc = "color:blue|label:S|" + srcAddress;
            String secondMarkerDst = "color:red|label:D|" + destAddres;
            String zoom = ""; //could be '&zoom=14'

            String FULL_GMAP_URL = "https://maps.googleapis.com/maps/api/staticmap?size="
                + size + "&path=" + path + "&markers=" + firstMarkerSrc + "&markers=" + secondMarkerDst +
                "&key=" + GOOGLEMAP_API_KEY;
            WebResponse req = WebRequest.Create(FULL_GMAP_URL).GetResponse();

            //If the GMAp api returns error
            if (req.Headers.Get("X-Staticmap-API-Warning") != "" && !ignoreException) {
                throw WrongGMapQueryException(null, FULL_GMAP_URL);
            }

            return new Bitmap(req.GetResponseStream());
        }

        /// <summary>Return an exception with HTTP details</summary>
        /// <param name="req">WebResponse variable</param>
        /// <param name="URL">Complete URL</param>

        Exception WrongGMapQueryException(WebClient req, String URL) {
            if (req == null) {
                return new Exception("Failed. URL : " + URL);
            }
            return new Exception("Failed. URL : " + URL + ". Headers : " + req.ResponseHeaders);
        }

        Station IVLibSoapService.getStationByName(string name) {
            foreach (Station station in JCDecaux_Stations_API.getInstance.Stations) {
                if (station.StationName.Equals(name)) {
                    return station;
                }
            }
            return null;
        }

 

        List<Step> IVLibSoapService.getInstructions(bool isPedestrian, string srcAddress, string destAddres) {

            List<Step> instructions = new List<Step>();

            foreach (Route route in getDirection(isPedestrian, srcAddress, destAddres).routes) {
                foreach (Leg leg in route.legs) {
                    foreach (Step step in leg.steps) {
                        instructions.Add((step));
                    }
                }
            }
            return instructions;
        }
    }
}
