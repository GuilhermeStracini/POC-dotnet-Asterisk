using Microsoft.Extensions.Logging.Abstractions;
using POCAsterisk.Controllers;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions;

namespace POCAsterisk.Tests.Controllers;

[ExcludeFromCodeCoverage]
public class WeatherForecastControllerTests
{
    private readonly WeatherForecastController _sut =
        new(new NullLogger<WeatherForecastController>());

    [Fact]
    public async Task GetValidRequestShouldReturnValidResponse()
    {
        // Arrange


        // Act
        var response = await _sut.GetAsync();

        // Assert
        response.Should().NotBeNull();
        response.Should().HaveCount(5);

        var items = response.ToList();
        items[0].TemperatureF.Should().Be(32 + (int)(items[0].TemperatureC / 0.5556));
        items[0].Summary.Should().NotBeNullOrEmpty();
        items[0].Date.Should().Be(DateOnly.FromDateTime(DateTime.Today));
    }
}
