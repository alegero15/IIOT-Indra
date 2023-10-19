namespace ITS.Indra.Infrastructure.Persistence;

using Dapper;
using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Threading.Tasks;

internal class WeatherStationsRepository : IWeatherStationsRepository
{
    private readonly string _connectionString;

    public WeatherStationsRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("db");
    }

    public async Task InsertAsync(WeatherStation weatherStation)
    {
        const string query = """
            INSERT INTO WeatherStations(
                    name,
                    latitude,
                    longitude,
                    code,
                    station_model)
            VALUES(
                    @Name,
                    @Latitude,
                    @Longitude,
                    @Code,
                    @StationModel);
            """;
        using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync(query, weatherStation);
    }
}
