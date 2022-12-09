using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace WebApiCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};

        private readonly ILogger<SomeController> _logger;

        public SomeController(ILogger<SomeController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet("test")]
        public string Test()
        {
            return "Some staff here";
        }

        [HttpGet("test/{id}")]
        public string TestById(int id, [FromQuery]bool status)
        {
            return $"Some staff here: {id} is active: {status}";
        }

        [HttpGet]
        public string TestGet([FromQuery]Point p)
        {
            return $"Point({p.X},{p.Y})";
        }

        [HttpPost]
        public string TestPost([FromBody] Point p)
        {
            return $"Point({p.X},{p.Y})";
        }

    }
}