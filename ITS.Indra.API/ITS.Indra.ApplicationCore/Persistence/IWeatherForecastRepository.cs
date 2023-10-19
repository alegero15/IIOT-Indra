namespace ITS.Indra.ApplicationCore.Persistence;

using ITS.Indra.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWeatherForecastRepository
{
    IEnumerable<WeatherForecast> GetList(int count);
}
