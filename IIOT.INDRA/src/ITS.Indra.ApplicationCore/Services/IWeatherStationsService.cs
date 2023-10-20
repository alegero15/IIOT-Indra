namespace ITS.Indra.ApplicationCore.Services;

using ITS.Indra.ApplicationCore.Entities;

using System.Threading.Tasks;

public interface IWeatherStationsService
{
    Task InsertAsync(WeatherStation weatherStation);

    Task<IEnumerable<WeatherStation>> GetAllAsync();
}
