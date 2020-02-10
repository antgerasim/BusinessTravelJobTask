using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BusinessTravelJobTask.ViewModels
{
    [DataContract]
    public class TravelDataItem 
    {
        [DataMember]
        public string TourDate { get; set; }
        [DataMember]
        public string HotelName { get; set; }
        [DataMember]
        public string RoomName { get; set; }
        [DataMember]
        public string MealType { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Currency { get; set; }
    }
}
