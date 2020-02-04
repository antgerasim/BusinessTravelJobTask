﻿using BusinessTravelJobTask.Cache;
using BusinessTravelJobTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static BusinessTravelJobTask.ViewModels.FilterVm;
using static BusinessTravelJobTask.ViewModels.SearchVm;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusinessTravelJobTask.Controllers
{
    [Route("api/[controller]")]
    public class TravelDataController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public TravelDataController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        // GET: api/<controller>
        [HttpGet("[action]")]
        public async Task<IActionResult> Search(int cityId, int countryId, string dateFrom, string dateTo)
        {
            var url = $"https://api2.mouzenidis.com/search?departureCities[0]={cityId}&countries[0]={countryId}&dateFrom={dateFrom}&dateTo={dateTo}&nights[0]=6&nights[1]=7&nights[2]=8&nights[3]=9&nights[4]=10";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            //add requestheaders ??...
            var client = _clientFactory.CreateClient(); //new HttpClient
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var jsonReader = new JsonTextReader(new StreamReader(responseStream));
                    var rootObj = JsonSerializer.Create().Deserialize<SearchRootObject>(jsonReader);
                    var retVal = rootObj.data.items.Select(item => new TravelData
                    {
                        TourDate = item.tour.tourDate.ToShortDateString(),
                        HotelName = item.hotels.FirstOrDefault()?.name,
                        RoomName = item.hotels.FirstOrDefault()?.room.name,
                        MealType = item.hotels.FirstOrDefault()?.mealType.name,
                        Price = item.price.value,
                        Currency = item.price.currencyCode
                    }).ToList();

                    return Ok(retVal);
                }
            }
            return NotFound();
        }

        // GET: api/<controller>
        [HttpGet("[action]")]
        [Cached(600)]
        public async Task<IActionResult> Filter()
        {
            var url = "https://api2.mouzenidis.com/search/filter/directions";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            //add requestheaders ??...
            var client = _clientFactory.CreateClient(); //new HttpClient
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var jsonReader = new JsonTextReader(new StreamReader(responseStream));
                    var rootObj = JsonSerializer.Create().Deserialize<FilterRootObject>(jsonReader);
                    //JsonConvert.DeserializeObject<RootObject>(myString);
                    return Ok(rootObj);
                }
            }
            return NotFound();
        }
    }
}