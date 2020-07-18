using GoogleMappApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace GoogleMappApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("api/Locations").Result;

            var locations = response.Content.ReadAsAsync<IEnumerable<Location>>().Result;

            ViewBag.Markers = JsonConvert.SerializeObject(locations);
            return View();            
        }
    }
}
