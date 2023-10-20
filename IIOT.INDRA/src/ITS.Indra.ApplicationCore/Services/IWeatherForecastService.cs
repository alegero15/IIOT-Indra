namespace ITS.Indra.ApplicationCore.Services
{
    using ITS.Indra.ApplicationCore.Entities;
    using System.Collections.Generic;

    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast(int count);
    }
}