using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VV_Market_Pull.Controllers
{
    [ApiController]
    [Route("[auctionLiveController]")]
    public class auctionLiveController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public auctionLiveController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
            })
            .ToArray();
        }
    }
}
