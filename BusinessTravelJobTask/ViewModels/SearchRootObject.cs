﻿using System.Runtime.Serialization;
using static BusinessTravelJobTask.ViewModels.SearchVm;

namespace BusinessTravelJobTask.ViewModels
{
    [DataContract]
    public class SearchRoot : IRootObject
    {
        [DataMember]
        public bool success { get; set; }
        [DataMember]
        public int elapsedMilliseconds { get; set; }
        [DataMember]
        public SearchVm.Data data { get; set; }
    }
}
