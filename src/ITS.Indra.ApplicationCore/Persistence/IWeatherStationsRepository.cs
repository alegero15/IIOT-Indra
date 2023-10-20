namespace ITS.Indra.ApplicationCore.Persistence;

using ITS.Indra.ApplicationCore.Entities;
using System.Threading.Tasks;

public interface IWeatherStationsRepository
{
    Task InsertAsync(WeatherStation weatherStation);

    Task<IEnumerable<WeatherStation>> GetAllAsync();

    Task<WeatherStation?> GetByIdAsync(int id);
}
