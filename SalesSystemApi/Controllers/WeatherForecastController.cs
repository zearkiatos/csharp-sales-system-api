using Microsoft.AspNetCore.Mvc;

namespace SalesSystemApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();

        weatherForecasts.Add(new WeatherForecast() { Id = 5, Name = "Hector" });
        weatherForecasts.Add(new WeatherForecast() { Id = 6, Name = "Francisco" });

        return weatherForecasts;
    }
}
