namespace ITS.Indra.Infrastructure.Persistence;

using Dapper;
using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class WeatherStationsRepository : IWeatherStationsRepository
{
    private readonly string _connectionString;

    public WeatherStationsRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("db");
    }

    public async Task<IEnumerable<WeatherStation>> GetAllAsync()
    {
        const string query = """
            SELECT
                    id as Id,
                    name as Name,
                    latitude as Latitude,
                    longitude as Longitude,
                    code as Code,
                    station_model as StationModel
            FROM WeatherStations
            """;
        using var connection = new NpgsqlConnection(_connectionString);
        return await connection.QueryAsync<WeatherStation>(query);
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
