namespace ITS.Indra.ApplicationCore.Services;

using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class WeatherStationsService: IWeatherStationsService
{
    private readonly IWeatherStationsRepository _weatherStationsRepository;

    public WeatherStationsService(IWeatherStationsRepository weatherStationsRepository)
    {
        _weatherStationsRepository = weatherStationsRepository;
    }

    public Task<IEnumerable<WeatherStation>> GetAllAsync()
    {
        return _weatherStationsRepository.GetAllAsync();
    }

    public Task InsertAsync(WeatherStation weatherStation)
    {
        return _weatherStationsRepository.InsertAsync(weatherStation);
    }
}
