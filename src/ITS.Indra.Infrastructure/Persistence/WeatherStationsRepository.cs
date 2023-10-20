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
                    longitudine as Longitudine,
                    code as Code,
                    station_model as StationModel
                FROM WeatherStations
                """;

        using var connection = new NpgsqlConnection(_connectionString);
        return await connection.QueryAsync<WeatherStation>(query);
    }

    public Task<WeatherStation> GetByIdAsync(int id)
    {
        const string query = """
                SELECT 
                    id as Id,
                    name as Name,
                    latitude as Latitude,
                    longitudine as Longitudine,
                    code as Code,
                    station_model as StationModel
                FROM WeatherStations
                WHERE id = @id 
                """;
        //anonymus type: quando l'argomento dentro new {} è uguale all'argomento GetByIdAsync() non serve dichiarare il tipo
        using var connection = new NpgsqlConnection(_connectionString);
        return await connection.QueryFirstOrDefault<WeatherStation>(query, new {id});
    }
}

    public async Task InsertAsync(WeatherStation weatherStation)
    {

        const string query = """
                INSERT INTO weatherstations(
                    name,
                    latitude,
                    longitudine,
                    code,
                    station_model)
                VALUES(
                    @Name,
                    @Latitude,
                    @Longitudine,
                    @Code,
                    @StationModel);
                """;

        using var connection = new NpgsqlConnection(_connectionString);
        await connection.ExecuteAsync(query, weatherStation);
        //dandoli in pasto un oggetto dapper mappa tutte le cose in base ai valori messi con  @

    }
}
