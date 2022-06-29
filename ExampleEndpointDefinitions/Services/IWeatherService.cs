using ExampleEndpointDefinitions.Endpoints;

namespace ExampleEndpointDefinitions.Services;

public interface IWeatherService
{
    public WeatherForecast[] GetWeatherForecast();
}