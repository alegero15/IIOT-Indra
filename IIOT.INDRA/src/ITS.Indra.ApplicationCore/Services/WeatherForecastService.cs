namespace ITS.Indra.ApplicationCore.Services;

using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;

    public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }

    public IEnumerable<WeatherForecast> GetWeatherForecast(int count)
    {
        return _weatherForecastRepository.GetList(count);
    }

}
