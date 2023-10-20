using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Services;

namespace ITS.Indra.API.Endpoints
{
    public static class WeatherStationsEndpoints
    {
        public static IEndpointRouteBuilder MapWeatherStationsEndpoints(this IEndpointRouteBuilder endpoints)
        {
            var group = endpoints.MapGroup("api/weatherstations");
            group.MapPost("/", InsertWeatherStation)
                 .WithName(nameof(InsertWeatherStation))
                 .WithOpenApi();
            return endpoints;
        }
        public static async Task<IResult> InsertWeatherStation(WeatherStation weatherStation, IWeatherStationsService weatherStationsService)
        {
            await weatherStationsService.InsertAsync(weatherStation);
            return Results.NoContent();
        }
    }
}
