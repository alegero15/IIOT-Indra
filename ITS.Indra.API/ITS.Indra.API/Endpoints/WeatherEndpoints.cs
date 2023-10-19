namespace ITS.Indra.API.Endpoints;

using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Services;
using Microsoft.AspNetCore.Mvc;

public static class WeatherEndpoints
{
    public static IEndpointRouteBuilder MapWeatherEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("api/weatherforecast");

        group.MapGet("/", GetWeatherForecast)
             .WithName("GetWeatherForecast")
             .WithOpenApi();

        return endpoints;
    }

    public static IEnumerable<WeatherForecast> GetWeatherForecast(IWeatherForecastService weatherForecastService)
    {
        var forecast = weatherForecastService.GetWeatherForecast(5);

        return forecast;
    }
}



