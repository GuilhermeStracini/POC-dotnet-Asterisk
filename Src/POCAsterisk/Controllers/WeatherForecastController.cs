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
        "Scorching",
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
    /// Asynchronously retrieves a collection of weather forecasts.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation, containing an enumerable collection of <see cref="WeatherForecast"/> objects.</returns>
    /// <remarks>
    /// This method simulates a delay to mimic an asynchronous operation, such as fetching data from a database or an external service.
    /// It generates a list of five weather forecasts, each with a date, temperature in Celsius, and a summary.
    /// The dates are set to the next five days starting from the current date, and the temperatures are randomly generated within the range of -20 to 55 degrees Celsius.
    /// The summary is randomly selected from a predefined array of summaries.
    /// </remarks>
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
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            })
            .ToArray();
    }
}
