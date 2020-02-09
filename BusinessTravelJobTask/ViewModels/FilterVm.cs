using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BusinessTravelJobTask.ViewModels
{
    public class FilterVm
    {
        [DataContract]
        public class Link
        {
            [DataMember]
            public int departureCityId { get; set; }
            [DataMember]
            public int transportId { get; set; }
            [DataMember]
            public int countryId { get; set; }
            [DataMember]
            public List<int> airports { get; set; }
            [DataMember]
            public List<int> tourTypeGroupIds { get; set; }
        }
        [DataContract]
        public class Country
        {
            [DataMember]
            public string currencyCode { get; set; }
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class DepartureCity
        {
            [DataMember]
            public int hotelCount { get; set; }
            [DataMember]
            public Country country { get; set; }
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int order { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Transport
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int order { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class TourTypeGroup
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int order { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Country2
        {
            [DataMember]
            public string currencyCode { get; set; }
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int order { get; set; }
            [DataMember]
            public string code { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Airport
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int order { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Dictionaries
        {
            [DataMember]
            public List<DepartureCity> departureCities { get; set; }
            [DataMember]
            public List<Transport> transports { get; set; }
            [DataMember]
            public List<TourTypeGroup> tourTypeGroups { get; set; }
            [DataMember]
            public List<Country2> countries { get; set; }
            [DataMember]
            public List<Airport> airports { get; set; }
        }

        [DataContract]
        public class Data :IData
        {
            [DataMember]
            public List<Link> links { get; set; }
            [DataMember]
            public Dictionaries dictionaries { get; set; }
        }

        [DataContract]
        public class FilterRootObject : IRootObject
        {
            [DataMember]
            public bool success { get; set; }
            [DataMember]
            public Data data { get; set; }
            [DataMember]
            public int elapsedMilliseconds { get; set; }
            
        }
    }
}
