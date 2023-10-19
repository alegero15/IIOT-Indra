namespace ITS.Indra.ApplicationCore;

using ITS.Indra.ApplicationCore.Services;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        services.AddScoped<IWeatherStationsService, WeatherStationsService>();

        return services;
    }
}
