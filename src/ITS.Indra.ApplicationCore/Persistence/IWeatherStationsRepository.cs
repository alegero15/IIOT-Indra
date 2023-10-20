namespace ITS.Indra.ApplicationCore.Persistence
{
    using ITS.Indra.ApplicationCore.Entities;
    using ITS.Indra.ApplicationCore.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IWeatherStationsRepository
    {
        Task InsertAsync(WeatherStation weatherStation);

        Task<IEnumerable<WeatherStation>> GetAllAsync();

        Task<WeatherStation> GetByIdAsync(int id);  
    }
}

//qualcuno ci implemet