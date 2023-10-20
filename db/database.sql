CREATE TABLE WeatherStations(
    id SERIAL PRIMARY KEY ,
    name VARCHAR(200) NOT NULL,
    latitude REAL,
    longitude REAL,
    code VARCHAR(50),
    station_model VARCHAR(50)
);

