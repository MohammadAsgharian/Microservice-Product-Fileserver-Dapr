using Microsoft.AspNetCore.Mvc;

namespace Microservice.Fileserver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileManagerController : ControllerBase
    {


        public FileManagerController(ILogger<FileManagerController> logger)
        {
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}