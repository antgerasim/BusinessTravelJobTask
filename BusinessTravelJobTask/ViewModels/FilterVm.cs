using System;
using System.Collections.Generic;

namespace BusinessTravelJobTask.ViewModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class TourType
    {
        public bool isGroup { get; set; }
        public string group { get; set; }
        public int id { get; set; }
        public int parentId { get; set; }
        public string name { get; set; }
    }

    public class SpoList
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class City
    {
        public int countryId { get; set; }
        public string countryName { get; set; }
        public bool isGroup { get; set; }
        public string group { get; set; }
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
    }

    public class Town
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public int countryId { get; set; }
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
    }

    public class Star
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Hotel
    {
        public int cityId { get; set; }
        public int townId { get; set; }
        public int countryId { get; set; }
        public string townName { get; set; }
        public string group { get; set; }
        public bool isRecommended { get; set; }
        public bool isBomoClub { get; set; }
        public bool isElionClub { get; set; }
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
    }

    public class AvailableDuration
    {
        public string date { get; set; }
        public List<int> durations { get; set; }
    }

    public class Pansion
    {
        public int id { get; set; }
        public int order { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Night
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class RoomCategory
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class RoomType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class HotelGroup
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class HotelFacility
    {
        public bool isGroup { get; set; }
        public string group { get; set; }
        public int id { get; set; }
        public int parentId { get; set; }
        public string name { get; set; }
    }

    public class Country
    {
        public string currencyCode { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class DepartureCity
    {
        public bool selected { get; set; }
        public int hotelCount { get; set; }
        public Country country { get; set; }
        public bool isGroup { get; set; }
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
    }

    public class Transport
    {
        public int id { get; set; }
        public int order { get; set; }
        public bool selected { get; set; }
        public string name { get; set; }
    }

    public class TourTypeGroup
    {
        public int id { get; set; }
        public int order { get; set; }
        public bool selected { get; set; }
        public string name { get; set; }
    }

    public class Country2
    {
        public string currencyCode { get; set; }
        public int id { get; set; }
        public int order { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public bool? selected { get; set; }
    }

    public class Airport
    {
        public int id { get; set; }
        public int order { get; set; }
        public string name { get; set; }
    }

    public class Filter
    {
        public List<TourType> tourTypes { get; set; }
        public List<SpoList> spoList { get; set; }
        public List<City> cities { get; set; }
        public List<Town> towns { get; set; }
        public List<Star> stars { get; set; }
        public List<Hotel> hotels { get; set; }
        public List<string> availableDates { get; set; }
        public List<AvailableDuration> availableDurations { get; set; }
        public List<Pansion> pansions { get; set; }
        public List<Night> nights { get; set; }
        public List<RoomCategory> roomCategories { get; set; }
        public List<RoomType> roomTypes { get; set; }
        public List<HotelGroup> hotelGroups { get; set; }
        public List<HotelFacility> hotelFacilities { get; set; }
        public List<int> adults { get; set; }
        public List<int> children { get; set; }
        public List<int> childrenAges { get; set; }
        public List<object> discounts { get; set; }
        public bool hideDirectCb { get; set; }
        public bool hideMouzCb { get; set; }
        public bool checkDirectCb { get; set; }
        public bool checkMouzCb { get; set; }
        public bool hasBomo { get; set; }
        public bool hasRecommended { get; set; }
        public bool hasPromo { get; set; }
        public int defaultCountryId { get; set; }
        public List<DepartureCity> departureCities { get; set; }
        public List<Transport> transports { get; set; }
        public List<TourTypeGroup> tourTypeGroups { get; set; }
        public List<Country2> countries { get; set; }
        public List<Airport> airports { get; set; }
        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }
    }

    public class Data
    {
        public Filter filter { get; set; }
    }

    public class Root : IRootObject
    {
        public bool success { get; set; }
        public int elapsedMilliseconds { get; set; }
        public Data data { get; set; }
    }
}