using System;
using BusinessTravelJobTask.ViewModels;

namespace BusinessTravelJobTask.Services
{
    public interface ITravelDataService<TRootObject, TResultObject> 
        where TRootObject : IRootObject
        where TResultObject : ITravelDataResult
    {
        TResultObject ProcessTravelData(Func<TRootObject, TResultObject> process, TRootObject sourceRoot);
    }
}