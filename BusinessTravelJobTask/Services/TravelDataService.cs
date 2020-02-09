using BusinessTravelJobTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static BusinessTravelJobTask.ViewModels.FilterVm;

namespace BusinessTravelJobTask.Services
{
    public class TravelDataService<TRootObject> where TRootObject : IRootObject
    {

        private Func<TRootObject, TRootObject> Reduce;

        public TravelDataService(Func<TRootObject, TRootObject> reduce)
        {
            Reduce = reduce;
        }
        public TRootObject ProcessTravelData(TRootObject sourceRoot)
        {
            var resultRoot = Reduce(sourceRoot);
           
            return resultRoot;
        }
    }
}
