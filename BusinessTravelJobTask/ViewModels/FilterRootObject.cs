using System.Runtime.Serialization;
using static BusinessTravelJobTask.ViewModels.FilterVm;

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
