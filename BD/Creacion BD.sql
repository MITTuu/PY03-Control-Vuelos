CREATE DATABASE AirlineControl;
GO

USE AirlineControl;
GO

CREATE TABLE Airline (
    idAirline INT PRIMARY KEY,
    name VARCHAR(255),
    motto VARCHAR(255)
);

CREATE TABLE City (
    idCity INT PRIMARY KEY,
    name VARCHAR(255)
);

CREATE TABLE Brand (
    idBrand INT PRIMARY KEY,
    name VARCHAR(255)
);

CREATE TABLE Plane (
    registrationNumber VARCHAR(50) PRIMARY KEY,
    idAirline INT,
    idBrand INT,
    capacity INT,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline),
    FOREIGN KEY (idBrand) REFERENCES Brand(idBrand)
);

CREATE TABLE Passengers (
    idPassenger INT PRIMARY KEY,
    name VARCHAR(255),
    lastName1 VARCHAR(255),
    lastName2 VARCHAR(255),
    email VARCHAR(255),
    phoneNumber VARCHAR(50)
);

CREATE TABLE Pilots (
    idPilot INT PRIMARY KEY,
    name VARCHAR(255),
    lastName1 VARCHAR(255),
    lastName2 VARCHAR(255),
    email VARCHAR(255),
    phoneNumber VARCHAR(50),
    idAirline INT,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline)
);

CREATE TABLE Flight (
    idFlight INT PRIMARY KEY,
    idAirline INT,
    idPilot INT,
    departureDateTime DATETIME,
    arrivalDateTime DATETIME,
    departureCityId INT,
    arrivalCityId INT,
    cancelled BIT,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline),
    FOREIGN KEY (idPilot) REFERENCES Pilots(idPilot),
    FOREIGN KEY (departureCityId) REFERENCES City(idCity),
    FOREIGN KEY (arrivalCityId) REFERENCES City(idCity)
);

CREATE TABLE FlightPassengers (
    idPassenger INT,
    idFlight INT,
    confirmed BIT,
    PRIMARY KEY (idPassenger, idFlight),
    FOREIGN KEY (idPassenger) REFERENCES Passengers(idPassenger),
    FOREIGN KEY (idFlight) REFERENCES Flight(idFlight)
);

CREATE TABLE Role (
    idRole INT PRIMARY KEY,
    name VARCHAR(255)
);

CREATE TABLE [User] (
    idUser INT PRIMARY KEY,
    email VARCHAR(255),
    password VARCHAR(255),
    idRole INT,
    FOREIGN KEY (idRole) REFERENCES Role(idRole)
);
