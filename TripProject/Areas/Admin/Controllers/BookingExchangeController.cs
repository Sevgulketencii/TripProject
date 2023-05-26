using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TripProject.Areas.Admin.Models;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingExchangeController : Controller
    {
		private readonly IHttpClientFactory _httpClient;

		public BookingExchangeController(IHttpClientFactory httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IActionResult> Index()
        {
			
			var client = _httpClient.CreateClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
				Headers =
	{
		{ "X-RapidAPI-Key", "2317275eaemshdfd923c9ef99791p177d5fjsn3466da4ddc66" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<BookingExchangeModel>(body);
				return View(values.exchange_rates);
			}
			
        }
    }
}
