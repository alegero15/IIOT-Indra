namespace ITS.Indra.API.Endpoints
{
    public static class WeatherStationsEndpoints
    {
        public static IEndpointRouteBuilder MapWeatherStationsEndpoints(this IEndpointRouteBuilder endpoints)
        {
            var group = endpoints.MapGroup("api/weatherstations");

            return endpoints;
        }
    }
}
