USE AirlineControl;
GO

-- Stored Procedures AppUSers
CREATE PROCEDURE GetUserByEmailAndPassword
    @Email VARCHAR(255),
    @Password VARCHAR(255)
AS
BEGIN
    SELECT 
        idUser,
        email,
        password,
        idRole
    FROM 
        AppUser 
    WHERE 
        email = @Email AND 
        password = @Password;
END;
GO

CREATE PROCEDURE GetAirlinesWithPlanes
AS
BEGIN
    SELECT 
        A.name AS AirlineName,
        P.registrationNumber AS PlaneID,
        B.name AS BrandName,
        P.capacity
    FROM 
        Airline A
    JOIN 
        Plane P ON A.idAirline = P.idAirline
    JOIN 
        Brand B ON P.idBrand = B.idBrand
    ORDER BY 
        A.name, P.registrationNumber;
END
GO

-- Stored Procedure para seleccionar todas las aerolíneas sin duplicados
CREATE PROCEDURE GetNameAirlines
AS
BEGIN
    SELECT DISTINCT  name
    FROM Airline;
END
GO

-- Stored Procedure para seleccionar todas las marcas
CREATE PROCEDURE GetNameBrands
AS
BEGIN
    SELECT DISTINCT name
    FROM Brand;
END
GO






CREATE PROCEDURE GetAllCities
AS
BEGIN
    SELECT
        cityCode,
        name
    FROM City
END;
GO

CREATE PROCEDURE GetFlights
    @selectedDate DATE,
    @selectedOrigin VARCHAR(3),
    @selectedDestination VARCHAR(3)
AS
BEGIN
    SELECT
        idFlight AS [Num],
        departureDateTime AS [Salida],
        registrationNumber AS [Avion]
    FROM Flight
    WHERE
        cancelled = 0 AND
        CONVERT(DATE, departureDateTime) = @selectedDate AND
        departureCityCode LIKE @selectedOrigin AND
        arrivalCityCode LIKE @selectedDestination
    ORDER BY departureDateTime
END;
GO

CREATE PROCEDURE InsertPassenger
    @passportNumber VARCHAR(32),
    @name VARCHAR(255),
    @lastName1 VARCHAR(255),
    @lastName2 VARCHAR(255),
    @email VARCHAR(255),
    @phoneNumber VARCHAR(50)
AS
BEGIN
    INSERT INTO Passengers
    (passportNumber, name, lastName1, lastName2, email, phoneNumber)
    VALUES
    (@passportNumber, @name, @lastName1, @lastName2, @email, @phoneNumber);

    SELECT SCOPE_IDENTITY() FROM Passengers
END;
GO

CREATE PROCEDURE GetPassengerByPassport
    @passportNumber VARCHAR(32)
AS
BEGIN
    SELECT
        idPassenger AS [ID],
        passportNumber AS [Pasaporte],
        name AS [Nombre],
        lastName1 AS [Apellido 1],
        lastName2 AS [Apellido 2],
        email,
        phoneNumber AS [Telefono]
    FROM Passengers
    WHERE
        passportNumber LIKE @passportNumber
END;
GO

CREATE PROCEDURE SaveAirline 
    @name VARCHAR(255),
    @motto VARCHAR(255)
AS
BEGIN 
     INSERT INTO Airline (name, motto) VALUES (@name, @motto);
END;
GO

USE AirlineControl;
GO

CREATE OR ALTER PROCEDURE GetAvailableSeats
    @idFlight INT
AS
BEGIN
    SELECT p.capacity - COUNT(fp.idPassenger) AS [Available Seats]
    FROM Flight AS f
    INNER JOIN Plane AS p ON f.registrationNumber = p.registrationNumber
    LEFT JOIN FlightPassengers AS fp ON f.idFlight = fp.idFlight
    WHERE f.idFlight = @idFlight
    GROUP BY p.capacity;
END;
GO

CREATE OR ALTER PROCEDURE RegisterPassengerInFlightByPassport
    @idFlight INT,
    @passportNumber VARCHAR(32)
AS
BEGIN
    INSERT INTO FlightPassengers
        (idFlight, idPassenger, confirmed)
        VALUES
        (@idFlight, (SELECT idPassenger FROM Passengers WHERE passportNumber = @passportNumber), 0)
END;
GO

CREATE PROCEDURE SavePlane 
    @registrationNumber VARCHAR(50),
    @idAirline INT,
    @idBrand INT,
    @capacity INT

AS
BEGIN 
     INSERT INTO Plane (registrationNumber, idAirline, idBrand, capacity) VALUES ( @registrationNumber, @idAirline, @idBrand, @capacity);
END;
GO