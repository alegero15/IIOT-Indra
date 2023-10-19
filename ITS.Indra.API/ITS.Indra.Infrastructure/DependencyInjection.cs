namespace ITS.Indra.Infrastructure;

using ITS.Indra.ApplicationCore.Persistence;
using ITS.Indra.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;


public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
        services.AddScoped<IWeatherStationsRepository, WeatherStationsRepository>();

        return services;
    }
}
