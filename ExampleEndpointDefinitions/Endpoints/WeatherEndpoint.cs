using EndpointDefinitions;
using ExampleEndpointDefinitions.Services;

namespace ExampleEndpointDefinitions.Endpoints;

public class WeatherEndpoint : IEndpointDefinition
{
    public void DefineServices(IServiceCollection services)
    {
        //Define services here
        services.AddScoped<IWeatherService, WeatherService>();
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/weatherforecast", GetWeatherForecast)
            .WithName("GetWeatherForecast");
    }

    private WeatherForecast[] GetWeatherForecast(IWeatherService service)
    {
        return service.GetWeatherForecast();
    }
}

public record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);
}