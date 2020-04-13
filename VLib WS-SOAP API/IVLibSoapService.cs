using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace VLib_WSSOAP_API {
    [ServiceContract]
    public interface IVLibSoapService {

        [OperationContract]
        bool fullFeed();

        [OperationContract]
        List<JCDecaux_API.Contract> getContracts(); 

        [OperationContract]
        List<JCDecaux_API.Station> getStations();

        [OperationContract]
        List<JCDecaux_API.Station> getAllStationsIn(string city);

        [OperationContract]
        Bitmap getStaticMapImage(bool isPedestrian, String srcAddress, String destAddres, bool ignoreException);

        [OperationContract]
        JCDecaux_API.Station getStationByName(String name);

        [OperationContract]
        List<Step> getInstructions(bool isPedestrian, String srcAddress, String destAddres);
         
    } 

    [DataContract]
    public class GeocodedWaypoint {
        public string geocoder_status { get; set; }
        public string place_id { get; set; }
        public List<string> types { get; set; }
    }
    [DataContract]

    public class Northeast {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    [DataContract]

    public class Southwest {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    [DataContract]

    public class Bounds {
        public Northeast northeast { get; set; }
        public Southwest southwest { get; set; }
    }
    [DataContract]

    public class Distance {
        [DataMember]

        public string text { get; set; }
        [DataMember]

        public int value { get; set; }
    }
    [DataContract]

    public class Duration {
        [DataMember]

        public string text { get; set; }
        [DataMember]

        public int value { get; set; }
    }
    [DataContract]

    public class EndLocation {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    [DataContract]

    public class StartLocation {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    [DataContract]

    public class Distance2 {
        [DataMember]

        public string text { get; set; }
        [DataMember]

        public int value { get; set; }
    }
    [DataContract]

    public class Duration2 {
        [DataMember]

        public string text { get; set; }
        [DataMember]

        public int value { get; set; }
    }
    [DataContract]

    public class EndLocation2 {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    [DataContract]

    public class Polyline {
        public string points { get; set; }
    }
    [DataContract]

    public class StartLocation2 {
        public double lat { get; set; }
        public double lng { get; set; }
    }
    [DataContract]

    public class Step {
        [DataMember]

        public Distance2 distance { get; set; }
        [DataMember]

        public Duration2 duration { get; set; }
        [DataMember]

        public EndLocation2 end_location { get; set; }
        [DataMember]

        public string html_instructions { get; set; }
        [DataMember]

        public Polyline polyline { get; set; }
        [DataMember]

        public StartLocation2 start_location { get; set; }
        [DataMember]

        public string travel_mode { get; set; }
        [DataMember]

        public string maneuver { get; set; }
    }
    [DataContract]

    public class Leg {
        public Distance distance { get; set; }
        public Duration duration { get; set; }
        public string end_address { get; set; }
        public EndLocation end_location { get; set; }
        public string start_address { get; set; }
        public StartLocation start_location { get; set; }
        public List<Step> steps { get; set; }
        public List<object> traffic_speed_entry { get; set; }
        public List<object> via_waypoint { get; set; }
    }
    [DataContract]

    public class OverviewPolyline {
        public string points { get; set; }
    }
    [DataContract]

    public class Route {
        public Bounds bounds { get; set; }
        public string copyrights { get; set; }
        public List<Leg> legs { get; set; }
        public OverviewPolyline overview_polyline { get; set; }
        public string summary { get; set; }
        public List<string> warnings { get; set; }
        public List<object> waypoint_order { get; set; }
    }
    [DataContract]

    public class Direction {
        public List<GeocodedWaypoint> geocoded_waypoints { get; set; }
       public List<Route> routes { get; set; }
        public string status { get; set; }
    }
}