namespace ITS.Indra.API.Endpoints;

using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Services;
using Microsoft.AspNetCore.Mvc;

public static class WeatherEndpoints
{
    public static IEndpointRouteBuilder MapWeatherEndpoints(this IEndpointRouteBuilder endpoints) //! con static posso usare this con questo non mi serve usare il costruttore
    {
        var group = endpoints.MapGroup("api/weatherforecast"); //sul programma di prima mettevamo tutte queste richieste sul program e questo era tutto un disordine

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



