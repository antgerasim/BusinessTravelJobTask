using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using static BusinessTravelJobTask.ViewModels.FilterVm;

namespace BusinessTravelJobTask.ViewModels
{
    [DataContract]
    public class FilterDataResult : ITravelDataResult
    {
        [DataMember]
        public bool success { get; set; }
        [DataMember]
        public int elapsedMilliseconds { get; set; }
        [DataMember]
        public dynamic data { get; set; }
    }
}
