using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Domain;
using System.Net;
using Sample.Application.Model;
using Sample.Application.Query;

namespace Sample.WebApi.Controllers
{
    public class xxxController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<xxxController> _logger;

        public xxxController(ILogger<xxxController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetRequestTest")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("GetXxx", Name = "JSON")]
        [ProducesResponseType(typeof(xxxDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetXxx([FromBody]GetXxxQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
