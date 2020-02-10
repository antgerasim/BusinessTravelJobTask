using BusinessTravelJobTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using static BusinessTravelJobTask.ViewModels.FilterVm;
using static BusinessTravelJobTask.ViewModels.SearchVm;

namespace BusinessTravelJobTask.Factories
{
   internal static class TravelDataSelectors
    {
        
        internal static TravelDataResult FilterFunc(FilterRoot rootObj)
        {
            dynamic data = new ExpandoObject();
            data.countries = rootObj.data.dictionaries.countries as IList<Country2>;
            data.departureCities = rootObj.data.dictionaries.departureCities as IList<FilterVm.DepartureCity>;

            var resultObj = new TravelDataResult()
            {
                success = rootObj.success,
                elapsedMilliseconds = rootObj.elapsedMilliseconds,
                data = data
            };

            return resultObj;
        }

        internal static TravelDataResult SearchFunc(SearchRoot rootObj)
        {
            var resultObj = new TravelDataResult()
            {
                success = rootObj.success,
                elapsedMilliseconds = rootObj.elapsedMilliseconds,
                data = rootObj.data.items.Select(item => new TravelDataItem
                {
                    TourDate = item.tour.tourDate.ToShortDateString(),
                    HotelName = item.hotels.FirstOrDefault()?.name,
                    RoomName = item.hotels.FirstOrDefault()?.room.name,
                    MealType = item.hotels.FirstOrDefault()?.mealType.name,
                    Price = item.price.value,
                    Currency = item.price.currencyCode
                }).ToList()
            };
            return resultObj;
        }
    }
}
