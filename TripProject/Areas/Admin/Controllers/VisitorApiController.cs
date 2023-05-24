using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TripProject.Areas.Admin.Models;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VisitorApiController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VisitorApiController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> GetList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:50079/api/Visitor");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VisitorModel>>(json);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddVisitor()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVisitor(VisitorModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var json = JsonConvert.SerializeObject(p);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:50079/api/Visitor", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetList");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response =await client.DeleteAsync("http://localhost:50079/api/Visitor/" + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetList");

            }
            return View();

        }
        
        [HttpGet]
        public async Task<IActionResult> UpdateVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:50079/api/Visitor/" + id);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<VisitorModel>(json);
                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVisitor(VisitorModel p)
        {
            var client = _httpClientFactory.CreateClient();
            var json = JsonConvert.SerializeObject(p);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("http://localhost:50079/api/Visitor", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetList");
            }
            return View();
        }
    }
}
