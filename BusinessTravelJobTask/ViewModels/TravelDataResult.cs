using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BusinessTravelJobTask.ViewModels
{
    [DataContract]
    public class TravelDataResult : ITravelDataResult
    {
        [DataMember]
        public bool success { get; set; }

        [DataMember]
        public int elapsedMilliseconds { get; set; }

        [DataMember]    
        public dynamic data { get; set; } 
       
    }
}
