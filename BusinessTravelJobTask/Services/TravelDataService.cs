using BusinessTravelJobTask.ViewModels;
using System;

namespace BusinessTravelJobTask.Services
{
    public class TravelDataService<TRootObject, TResultObject> : ITravelDataService<TRootObject, TResultObject> where TRootObject : IRootObject
    where TResultObject : ITravelDataResult
    {

        public TResultObject ProcessTravelData(Func<TRootObject, TResultObject> process, TRootObject sourceRoot)
        {
            var resultRoot = process(sourceRoot);

            return resultRoot;
        }
    }
}