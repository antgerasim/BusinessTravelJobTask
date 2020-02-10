using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BusinessTravelJobTask.ViewModels
{
    public class SearchVm
    {
        [DataContract]
        public class RoomType
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class RoomCategory
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class RoomAccomodation
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Room
        {
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public bool hasFullDescription { get; set; }
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public RoomType roomType { get; set; }
            [DataMember]
            public RoomCategory roomCategory { get; set; }
            [DataMember]
            public RoomAccomodation roomAccomodation { get; set; }
        }
        [DataContract]
        public class MealType
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Link
        {
            [DataMember]
            public string seoUrl { get; set; }
            [DataMember]
            public string type { get; set; }
        }
        [DataContract]
        public class City
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Region
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Country
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Stars
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string code { get; set; }
        }
        [DataContract]
        public class Location
        {
            [DataMember]
            public double latitude { get; set; }
            [DataMember]
            public double longitude { get; set; }
            [DataMember]
            public string distanceToSea { get; set; }
            [DataMember]
            public string address { get; set; }
        }
        [DataContract]
        public class Photo
        {
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public string thumbnailUrl { get; set; }
            [DataMember]
            public int order { get; set; }
        }
        [DataContract]
        public class Hotel
        {
            [DataMember]
            public int idInterlook { get; set; }
            [DataMember]
            public DateTime dateBegin { get; set; }
            [DataMember]
            public DateTime dateEnd { get; set; }
            [DataMember]
            public string description { get; set; }
            [DataMember]
            public string shortDescription { get; set; }
            [DataMember]
            public string photo { get; set; }
            [DataMember]
            public string roomsDescription { get; set; }
            [DataMember]
            public string spa { get; set; }
            [DataMember]
            public string pansions { get; set; }
            [DataMember]
            public string meals { get; set; }
            [DataMember]
            public string url { get; set; }
            [DataMember]
            public int nightsDuration { get; set; }
            [DataMember]
            public int roomsCount { get; set; }
            [DataMember]
            public int reviews { get; set; }
            [DataMember]
            public bool isRecommended { get; set; }
            [DataMember]
            public bool isExclusive { get; set; }
            [DataMember]
            public bool isBomoClub { get; set; }
            [DataMember]
            public bool isElionClub { get; set; }
            [DataMember]
            public bool isProgram { get; set; }
            [DataMember]
            public bool isChildrenCamp { get; set; }
            [DataMember]
            public Room room { get; set; }
            [DataMember]
            public MealType mealType { get; set; }
            [DataMember]
            public Link link { get; set; }
            [DataMember]
            public City city { get; set; }
            [DataMember]
            public Region region { get; set; }
            [DataMember]
            public Country country { get; set; }
            [DataMember]
            public Stars stars { get; set; }
            [DataMember]
            public Location location { get; set; }
            [DataMember]
            public List<Photo> photos { get; set; }
            [DataMember]
            public List<object> facilities { get; set; }
            [DataMember]
            public List<object> vacationTypes { get; set; }
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public double? rating { get; set; }
        }
        [DataContract]
        public class Quota
        {
            [DataMember]
            public List<string> hotel { get; set; }
            [DataMember]
            public List<string> airplaneTo { get; set; }
            [DataMember]
            public List<string> airplaneFrom { get; set; }
        }
        [DataContract]
        public class Price
        {
            [DataMember]
            public double value { get; set; }
            [DataMember]
            public double baseValue { get; set; }
            [DataMember]
            public string code { get; set; }
            [DataMember]
            public string currencyCode { get; set; }
        }
        [DataContract]
        public class DepartureCity
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Link2
        {
            [DataMember]
            public string seoUrl { get; set; }
            [DataMember]
            public string type { get; set; }
        }
        [DataContract]
        public class TourType
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int parentId { get; set; }
            [DataMember]
            public string parentName { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class FlightReturnCity
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string name { get; set; }
        }
        [DataContract]
        public class Tour
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public int departureCityId { get; set; }
            [DataMember]
            public DepartureCity departureCity { get; set; }
            [DataMember]
            public DateTime tourDate { get; set; }
            [DataMember]
            public string date { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string transportType { get; set; }
            [DataMember]
            public Link2 link { get; set; }
            [DataMember]
            public List<object> labels { get; set; }
            [DataMember]
            public List<TourType> tourTypes { get; set; }
            [DataMember]
            public FlightReturnCity flightReturnCity { get; set; }
            [DataMember]
            public bool isNonRefundable { get; set; }
            [DataMember]
            public bool hasTransfer { get; set; }
            [DataMember]
            public bool hasFlight { get; set; }
        }
        [DataContract]
        public class FlightsDetails
        {
            [DataMember]
            public double gdsFlightPrice { get; set; }
            [DataMember]
            public bool containsGdsFlights { get; set; }
            [DataMember]
            public bool containsOnlyDirectFlights { get; set; }
            [DataMember]
            public bool existsMztFlightsVariant { get; set; }
            [DataMember]
            public bool existsOnlyDirectFlightsVariant { get; set; }
        }
        [DataContract]
        public class Item
        {
            [DataMember]
            public int durationByTourDays { get; set; }
            [DataMember]
            public int durationByHotelNights { get; set; }
            [DataMember]
            public string hash { get; set; }
            [DataMember]
            public List<Hotel> hotels { get; set; }
            [DataMember]
            public Quota quota { get; set; }
            [DataMember]
            public Price price { get; set; }
            [DataMember]
            public Tour tour { get; set; }
            [DataMember]
            public FlightsDetails flightsDetails { get; set; }
        }
        [DataContract]
        public class Data  
        {
            [DataMember]
            public List<Item> items { get; set; }
            [DataMember]
            public bool hasMore { get; set; }
            [DataMember]
            public int total { get; set; }
        }
    }
}
