namespace ITS.Indra.ApplicationCore.Services;

using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class WeatherStationsService : IWeatherStationsService
{
    private readonly IWeatherStationsRepository _weatherStationsRepository;

    public WeatherStationsService(IWeatherStationsRepository weatherStationsRepository)
    {
        _weatherStationsRepository = weatherStationsRepository;
    }

    Task<IEnumerable<WeatherStation>> GetAllAsync()
    {
        return _weatherStationsRepository.GetAllAsync();
    }

    public Task InsertAsync(WeatherStation weatherStation)
    {
        return _weatherStationsRepository.InsertAsync(weatherStation);
    }

    //la logica non va dentro alle api, perchè l'applicazione non sarà piu utilizzabile se cambio qualcosa (questo è il caso della scorsa volta, con dapper tutto dentro un codice.
    //Il logic service permette di centralizzare la logica; la repository invece permettono solo di richiamare i dati dal db
    //Ci serve un pezzo in mezzo per gestire le chiamate dalle api ai repository; le cose in piu le gestisco comodamente dentro il Logic Service; alcuni metodi fanno solo la strada api repository altre applicazioni come amazon/eccomerce le logiche gestiscono il tutto come mail, gestionale; facendo cio vediamo meglio i dati e li gestiamo bene graze a questa CORE APPLICATION che è La logic service
    // l'anno scorso la cartella service era direttamente dentro il progetto stesso, questa non è buona cosa, perchè non è ottimizzato, anche per la prossima manutenzione, è molto difficile sistemare e aggiornare le cose
    //
}
