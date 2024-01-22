using Microsoft.AspNetCore.Mvc;

namespace POCAsterisk.Controllers;

/// <summary>
/// Class WeatherForecastController.
/// Implements the <see cref="ControllerBase" />
/// </summary>
/// <seealso cref="ControllerBase" />
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    /// <summary>
    /// The summaries
    /// </summary>
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger<WeatherForecastController> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="WeatherForecastController" /> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Get as an asynchronous operation.
    /// </summary>
    /// <returns>A Task&lt;IEnumerable`1&gt; representing the asynchronous operation.</returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> GetAsync()
    {
        _logger.LogInformation("GetWeatherForecast called");

        await Task.Delay(1000);

        return Enumerable
            .Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}
