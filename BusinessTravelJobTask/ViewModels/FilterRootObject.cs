using System.Runtime.Serialization;
//using static BusinessTravelJobTask.ViewModels.FilterVmOld;

namespace BusinessTravelJobTask.ViewModels
{
    [DataContract]
    public class FilterRoot : IRootObject
    {
        [DataMember]
        public bool success { get; set; }
        [DataMember]
        public int elapsedMilliseconds { get; set; }
        [DataMember]
        public Data data { get; set; }
    }
}
