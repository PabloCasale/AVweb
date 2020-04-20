using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AVweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AVweb.Controllers
{
    public class HomeController : Controller
    {
        readonly ILogger<HomeController> _log;

        public HomeController(ILogger<HomeController> log)
        {
            _log = log;
        }

        public IActionResult Index(int id)
        {
            var weather = new Forecast();
            weather.GetWeatherData("Buenos Aires","Argentina");
            _log.LogInformation($"[REQUEST DEFAULT]: {weather.City} : {weather.Country} {DateTime.Now.ToString()}");
            return View(weather);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(int id, string city, string country)
        {
            _log.LogInformation($"[REQUEST]: {city} : {country} {DateTime.Now.ToString()}");
            var weather = new Forecast();
            weather.GetWeatherData(city, country);
            return View(weather);
        }
    }
}