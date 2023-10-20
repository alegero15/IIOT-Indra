create TABLE WeatherStations
(
    id serial primary key,
    name VARCHAR (200),
    latitude REAL,
    longitude REAl,
    code varchar (50),
    station_model VARCHAR(50)
);

DROP TABLE WeatherStations;
