namespace ITS.Indra.Infrastructure.Persistence;

using ITS.Indra.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;

internal class WeatherStationsRepository : IWeatherStationsRepository
{
    private readonly string _connectionString;

    public WeatherStationsRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("db");
    }


}
