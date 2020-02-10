using BusinessTravelJobTask.Factories;
using BusinessTravelJobTask.Services;
using BusinessTravelJobTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessTravelJobTask.Controllers
{
    [Route("api/[controller]")]
    public class TravelDataController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ITravelDataService<FilterRoot, TravelDataResult> _filterService;
        private readonly ITravelDataService<SearchRoot, TravelDataResult> _searchService;

        public TravelDataController(IHttpClientFactory clientFactory,
            ITravelDataService<FilterRoot, TravelDataResult> filterService,
            ITravelDataService<SearchRoot, TravelDataResult> searchService
            )
        {
            _clientFactory = clientFactory;
            _filterService = filterService;
            _searchService = searchService;
        }

        // GET: api/<controller>
        [HttpGet("[action]")]
        //[Cached(600)]
        public async Task<IActionResult> Filter()
        {
            var url = "https://api2.mouzenidis.com/search/filter/directions";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            //add requestheaders ??...
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            return await GetActionResult<FilterRoot>(response);
        }

        // GET: api/<controller>
        [HttpGet("[action]")]
        public async Task<IActionResult> Search(int cityId, int countryId, string dateFrom, string dateTo)
        {
            var url = $"https://api2.mouzenidis.com/search?departureCities[0]={cityId}&countries[0]={countryId}&dateFrom={dateFrom}&dateTo={dateTo}&nights[0]=6&nights[1]=7&nights[2]=8&nights[3]=9&nights[4]=10";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            //add requestheaders ??...
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            return await GetActionResult<SearchRoot>(response);
        }

        private async Task<IActionResult> GetActionResult<TRoot>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var jsonReader = new JsonTextReader(new StreamReader(responseStream));
                    var rootObjectType = typeof(TRoot);
                    var retVal = default(TravelDataResult);

                    switch (true)
                    {
                        case true when typeof(FilterRoot).IsAssignableFrom(rootObjectType):
                            var filterResult = JsonSerializer.Create().Deserialize<FilterRoot>(jsonReader);
                            retVal = _filterService.ProcessTravelData(TravelDataSelectors.FilterFunc, filterResult);
                            return Ok(retVal);

                        case true when typeof(SearchRoot).IsAssignableFrom(rootObjectType):
                            var serchResult = JsonSerializer.Create().Deserialize<SearchRoot>(jsonReader);
                            retVal = _searchService.ProcessTravelData(TravelDataSelectors.SearchFunc, serchResult);
                            return Ok(retVal);

                        default:
                            var paramName = rootObjectType.FullName;
                            throw new ArgumentException(
                                message: $"{paramName} неизвестный тип",
                                paramName: paramName);
                    }
                }
            }
            return NotFound();
        }
    }
}