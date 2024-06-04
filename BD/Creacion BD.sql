CREATE DATABASE AirlineControl;
GO

USE AirlineControl;
GO

CREATE TABLE Airline (
    idAirline INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    motto VARCHAR(255) NOT NULL
);

CREATE TABLE City (
    idCity INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE Brand (
    idBrand INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE Plane (
    registrationNumber VARCHAR(50) PRIMARY KEY NOT NULL,
    idAirline INT NOT NULL,
    idBrand INT NOT NULL,
    capacity INT NOT NULL,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline),
    FOREIGN KEY (idBrand) REFERENCES Brand(idBrand)
);

CREATE TABLE Passengers (
    idPassenger INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    lastName1 VARCHAR(255) NOT NULL,
    lastName2 VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    phoneNumber VARCHAR(50) NOT NULL
);

CREATE TABLE Pilots (
    idPilot INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    lastName1 VARCHAR(255) NOT NULL,
    lastName2 VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    phoneNumber VARCHAR(50) NOT NULL,
    idAirline INT NOT NULL,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline)
);

CREATE TABLE Flight (
    idFlight INT PRIMARY KEY NOT NULL,
    idAirline INT NOT NULL,
    idPilot INT NOT NULL,
    departureDateTime DATETIME NOT NULL,
    arrivalDateTime DATETIME NOT NULL,
    departureCityId INT NOT NULL,
    arrivalCityId INT NOT NULL,
    cancelled BIT NOT NULL,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline),
    FOREIGN KEY (idPilot) REFERENCES Pilots(idPilot),
    FOREIGN KEY (departureCityId) REFERENCES City(idCity),
    FOREIGN KEY (arrivalCityId) REFERENCES City(idCity)
);

CREATE TABLE FlightPassengers (
    idPassenger INT NOT NULL,
    idFlight INT NOT NULL,
    confirmed BIT NOT NULL,
    PRIMARY KEY (idPassenger, idFlight),
    FOREIGN KEY (idPassenger) REFERENCES Passengers(idPassenger),
    FOREIGN KEY (idFlight) REFERENCES Flight(idFlight)
);

CREATE TABLE Role (
    idRole INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE AppUser (
    idUser INT PRIMARY KEY NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    idRole INT NOT NULL,
    FOREIGN KEY (idRole) REFERENCES Role(idRole)
);
