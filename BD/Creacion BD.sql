CREATE DATABASE AirlineControl;
GO

USE AirlineControl;
GO

CREATE TABLE Airline (
    idAirline INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    motto VARCHAR(255) NOT NULL
);

CREATE TABLE City (
    cityCode VARCHAR(3) PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE Brand (
    idBrand INT PRIMARY KEY NOT NULL IDENTITY(1,1),
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
    idPassenger INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    passportNumber VARCHAR(32) NOT NULL UNIQUE,
    name VARCHAR(255) NOT NULL,
    lastName1 VARCHAR(255) NOT NULL,
    lastName2 VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    phoneNumber VARCHAR(50) NOT NULL
);

CREATE TABLE Pilots (
    idPilot INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    lastName1 VARCHAR(255) NOT NULL,
    lastName2 VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    phoneNumber VARCHAR(50) NOT NULL,
    idAirline INT NOT NULL,
    FOREIGN KEY (idAirline) REFERENCES Airline(idAirline)
);

CREATE TABLE Flight (
    idFlight INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    registrationNumber VARCHAR(50) NOT NULL,
    idPilot INT NOT NULL,
    departureDateTime DATETIME NOT NULL,
    arrivalDateTime DATETIME NOT NULL,
    departureCityCode VARCHAR(3) NOT NULL,
    arrivalCityCode VARCHAR(3) NOT NULL,
    cancelled BIT NOT NULL,
    FOREIGN KEY (registrationNumber) REFERENCES Plane(registrationNumber),
    FOREIGN KEY (idPilot) REFERENCES Pilots(idPilot),
    FOREIGN KEY (departureCityCode) REFERENCES City(cityCode),
    FOREIGN KEY (arrivalCityCode) REFERENCES City(cityCode)
);

CREATE TABLE FlightPassengers (
    idPassenger INT NOT NULL,
    idFlight INT NOT NULL,
    confirmed BIT NOT NULL,
    PRIMARY KEY (idPassenger, idFlight),
    FOREIGN KEY (idPassenger) REFERENCES Passengers(idPassenger),
    FOREIGN KEY (idFlight) REFERENCES Flight(idFlight)
);

CREATE TABLE Roles (
    idRole INT PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE AppUser (
    idUser INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    idRole INT NOT NULL,
    FOREIGN KEY (idRole) REFERENCES Roles(idRole)
);


-- Arreglo tabla Vuelo

ALTER TABLE Flight
DROP CONSTRAINT FK__Flight__idAirlin__48CFD27E;

ALTER TABLE Flight
DROP COLUMN idAirline;
GO

ALTER TABLE Flight
ADD registrationNumber VARCHAR(50) NOT NULL;

ALTER TABLE Flight
ADD CONSTRAINT FK_Flight_Plane
FOREIGN KEY (registrationNumber) REFERENCES Plane(registrationNumber);
GO