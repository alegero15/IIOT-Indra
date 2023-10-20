using ITS.Indra.API.Endpoints;
using ITS.Indra.ApplicationCore;
using ITS.Indra.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();  //!settiamo tutti i servizi che sono dentro alla funzione CreateBuilder della classe WebApplication
builder.Services.AddInfrastructure();

var app = builder.Build(); //! una volta settati i servizi, creiamo la nostra app usando builder che eredita tutti i servizi

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapWeatherStationsEndpoints();
app.MapWeatherEndpoints();

app.Run();


//!questa è la prima configurazione per creare API, qua prima nel programma classica dell'anno scorso andavano tutte le richieste Map, Post...
