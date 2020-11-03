using BusinessTravelJobTask.ViewModels;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace BusinessTravelJobTask.Factories
{
    internal static class TravelDataSelectors
    {
        internal static TravelDataResult FilterFunc(FilterRoot rootObj)
        {
            dynamic data = new ExpandoObject();
            data.countries = rootObj.data.filter.countries as IList<Country2>;
            data.departureCities = rootObj.data.filter.departureCities as IList<ViewModels.DepartureCity>;

            var resultObj = new TravelDataResult()
            {
                success = rootObj.success,
                elapsedMilliseconds = rootObj.elapsedMilliseconds,

                data = new
                {
                    countries = rootObj.data.filter.countries as IList<Country2>,
                    departureCities = rootObj.data.filter.departureCities as IList<ViewModels.DepartureCity>
                }
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