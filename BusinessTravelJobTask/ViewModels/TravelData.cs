﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTravelJobTask.ViewModels
{
    public class TravelDataRoot : IRootObject
    {
        public IList<TravelDataItem> Items { get; set; }
    }

    public class TravelDataItem
    {
        public string TourDate { get; set; }
        public string HotelName { get; set; }
        public string RoomName { get; set; }
        public string MealType { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public int elapsedMilliseconds { get; set; }
        public bool success { get; set; }
    }
}
