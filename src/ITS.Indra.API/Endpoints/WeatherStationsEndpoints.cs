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

            group.MapGet("/", GetAllWeatherStation)
            .WithName(nameof(GetAllWeatherStation))
            .WithOpenApi();

            group.MapGet("/{id}", GetWeatherStation)
            .WithName(nameof(GetWeatherStation))
            .WithOpenApi();


            return endpoints;
        }
        public static async Task<IResult> InsertWeatherStation(WeatherStation weatherStation, IWeatherStationsService weatherStationsService)
        {
            await weatherStationsService.InsertAsync(weatherStation);
            return Results.NoContent();
        }

        public static async Task<IResult> GetAllWeatherStation(IWeatherStationsService weatherStationsService)
        {
            var list = await weatherStationsService.GetAllAsync();
            return Results.Ok(list);
        }

        public static async Task<IResult> GetWeatherStation(int id, IWeatherStationsService weatherStationsService)
        {
            var item = await weatherStationsService.GetByIdAsync(id);
            if (item == null)
                return Results.NotFound();

            return Results.Ok(item);
        }
    }
}
