USE AirlineControl;
GO

-- Stored Procedures AppUSers
CREATE OR ALTER PROCEDURE GetUserByEmailAndPassword
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

CREATE OR ALTER PROCEDURE GetAirlinesWithPlanes
AS
BEGIN
    SELECT 
        A.idAirline,
        A.name AS AirlineName,
        A.motto,
        P.registrationNumber AS PlaneID,
        B.name AS BrandName,
        P.capacity
    FROM 
        Airline A
    LEFT JOIN 
        Plane P ON A.idAirline = P.idAirline
    LEFT JOIN 
        Brand B ON P.idBrand = B.idBrand
    ORDER BY 
        A.name, P.registrationNumber;
END
GO


-- Stored Procedure para seleccionar todas las aerol�neas sin duplicados
CREATE OR ALTER PROCEDURE GetNameAirlines
AS
BEGIN
    SELECT DISTINCT  name
    FROM Airline;
END
GO

-- Stored Procedure para seleccionar todas las marcas
CREATE OR ALTER PROCEDURE GetNameBrands
AS
BEGIN
    SELECT DISTINCT name
    FROM Brand;
END
GO

CREATE OR ALTER PROCEDURE GetAllCities
AS
BEGIN
    SELECT
        cityCode,
        name
    FROM City
END;
GO

CREATE OR ALTER PROCEDURE GetFlights
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
        arrivalCityCode LIKE @selectedDestination AND
        cancelled = 0
    ORDER BY departureDateTime
END;
GO

CREATE OR ALTER PROCEDURE GetAllFlightsInfo
AS
BEGIN
    SELECT
        fl.idFlight AS [Num],
        fl.departureDateTime AS [Salida],
        fl.arrivalDateTime AS [Llegada],
        (SELECT name FROM City WHERE cityCode = fl.departureCityCode) AS [Ciudad Partida],
        (SELECT name FROM City WHERE cityCode = fl.arrivalCityCode) AS [Ciudad Llegada],
        fl.registrationNumber AS [Avion],
        CONCAT_WS(' ', pl.name, pl.lastName1, pl.lastName2) AS [Nombre de Piloto]
    FROM Flight fl
    INNER JOIN Plane pn ON fl.registrationNumber = pn.registrationNumber
    INNER JOIN Pilots pl ON fl.idPilot = pl.idPilot
    INNER JOIN Airline al ON pn.idAirline = al.idAirline
    ORDER BY departureDateTime DESC
END;
GO

CREATE OR ALTER PROCEDURE GetPlaneFlights
    @registrationNumber VARCHAR(30)
AS
BEGIN
    SELECT
        fl.idFlight AS [Num],
        fl.departureDateTime AS [Salida],
        fl.arrivalDateTime AS [Llegada],
        (SELECT name FROM City WHERE cityCode = fl.departureCityCode) AS [Ciudad Partida],
        (SELECT name FROM City WHERE cityCode = fl.arrivalCityCode) AS [Ciudad Llegada],
        fl.registrationNumber AS [Avion],
        CONCAT_WS(' ', pl.name, pl.lastName1, pl.lastName2) AS [Nombre de Piloto]
    FROM Flight fl
    INNER JOIN Plane pn ON fl.registrationNumber = pn.registrationNumber
    INNER JOIN Pilots pl ON fl.idPilot = pl.idPilot
    INNER JOIN Airline al ON pn.idAirline = al.idAirline
    WHERE pn.registrationNumber = @registrationNumber
    ORDER BY departureDateTime DESC
END;
GO

CREATE OR ALTER PROCEDURE GetPassengerFlights
    @passportNumber VARCHAR(30)
AS
BEGIN
    SELECT
        fl.idFlight AS [Num],
        fl.departureDateTime AS [Salida],
        fl.arrivalDateTime AS [Llegada],
        (SELECT name FROM City WHERE cityCode = fl.departureCityCode) AS [Ciudad Partida],
        (SELECT name FROM City WHERE cityCode = fl.arrivalCityCode) AS [Ciudad Llegada],
        fl.registrationNumber AS [Avion],
        CONCAT_WS(' ', pl.name, pl.lastName1, pl.lastName2) AS [Nombre de Piloto]
    FROM FlightPassengers fp
    INNER JOIN Flight fl ON fp.idFlight = fl.idFlight
    INNER JOIN Plane pn ON fl.registrationNumber = pn.registrationNumber
    INNER JOIN Pilots pl ON fl.idPilot = pl.idPilot
    INNER JOIN Airline al ON pn.idAirline = al.idAirline
    WHERE fp.idPassenger = (SELECT idPassenger FROM Passengers WHERE passportNumber = @passportNumber)
    ORDER BY departureDateTime DESC
END;
GO

CREATE OR ALTER PROCEDURE GetFlightPassengers
    @idFlight INT
AS
BEGIN
    SELECT
        ps.passportNumber AS [Pasaporte],
        ps.name AS [Nombre],
        ps.lastName1 AS [Apellido 1],
        ps.lastName2 AS [Apellido 2],
        ps.email,
        ps.phoneNumber AS [Telefono]
    FROM FlightPassengers AS fp
    INNER JOIN Passengers AS ps ON fp.idPassenger = ps.idPassenger
    WHERE fp.idFlight = @idFlight
END;
GO

CREATE OR ALTER PROCEDURE GetAllPassengers
AS
BEGIN
    SELECT
        passportNumber AS [Pasaporte],
        name AS [Nombre],
        lastName1 AS [Apellido 1],
        lastName2 AS [Apellido 2],
        email,
        phoneNumber AS [Telefono]
    FROM Passengers
END;
GO

CREATE OR ALTER PROCEDURE InsertPassenger
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

CREATE OR ALTER PROCEDURE GetPassengerByPassport
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

CREATE OR ALTER PROCEDURE SaveAirline 
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

CREATE OR ALTER PROCEDURE SavePlane 
    @registrationNumber VARCHAR(50),
    @idAirline INT,
    @idBrand INT,
    @capacity INT

AS
BEGIN 
     INSERT INTO Plane (registrationNumber, idAirline, idBrand, capacity) VALUES ( @registrationNumber, @idAirline, @idBrand, @capacity);
END;
GO

CREATE OR ALTER PROCEDURE GetAllPlanes
AS 
BEGIN
    SELECT p.registrationNumber, a.name AS Airline, b.name AS Brand, p.capacity
    FROM Plane p
    INNER JOIN Airline a ON p.idAirline = a.idAirline
    INNER JOIN Brand b ON p.idBrand = b.idBrand
END;
GO

-- Stored procedures Flights
CREATE OR ALTER PROCEDURE GetAirlines
AS
BEGIN
	SELECT idAirline, name, motto
	FROM Airline
END;
GO

CREATE OR ALTER PROCEDURE GetPlaneByIdAirline
	@idAirline INT
AS
BEGIN
	SELECT p.registrationNumber, b.name, p.capacity
	FROM Plane p
	INNER JOIN Brand b ON b.idBrand = p.idBrand
	WHERE p.idAirline = @idAirline
END;
GO

CREATE OR ALTER PROCEDURE GetPilotsByIdAirline
	@idAirline INT
AS
BEGIN
	SELECT idPilot, name, lastName1, lastName2, email, phoneNumber
	FROM Pilots
	WHERE idAirline = @idAirline
END;
GO

CREATE OR ALTER PROCEDURE GetCities
AS
BEGIN
	SELECT cityCode, name
	FROM City
END;
GO

CREATE OR ALTER PROCEDURE isPilotAvailable
    @idPilot INT,
    @departureDate DATETIME,
    @arrivalDate DATETIME
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Flight
        WHERE idPilot = @idPilot
        AND departureDateTime <= @arrivalDate
        AND arrivalDateTime >= @departureDate
		AND cancelled = 0
    )
    BEGIN
        SELECT 1 AS IsPilotBusy; -- El piloto est� ocupado en ese rango de fechas
    END
    ELSE
    BEGIN
        SELECT 0 AS IsPilotBusy; -- El piloto no est� ocupado en ese rango de fechas
    END
END;
GO

CREATE OR ALTER PROCEDURE InsertFlight
    @idPilot INT,
    @departureDateTime DATETIME,
    @arrivalDateTime DATETIME,
    @departureCityCode VARCHAR(3),
    @arrivalCityCode VARCHAR(3),
    @cancelled BIT,
	@registrationNumber VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Flight (idPilot, departureDateTime, arrivalDateTime, departureCityCode, arrivalCityCode, cancelled, registrationNumber)
    VALUES (@idPilot, @departureDateTime, @arrivalDateTime, @departureCityCode, @arrivalCityCode, @cancelled, @registrationNumber);
END;
GO

CREATE OR ALTER PROCEDURE InsertPilot
    @nombre VARCHAR(255),
    @apellido1 VARCHAR(255),
    @apellido2 VARCHAR(255),
    @correo VARCHAR(255),
    @telefono VARCHAR(50),
    @idAerolinea INT
AS
BEGIN
    INSERT INTO Pilots (name, lastName1, lastName2, email, phoneNumber, idAirline)
    VALUES (@nombre, @apellido1, @apellido2, @correo, @telefono, @idAerolinea);
END;
GO



CREATE OR ALTER PROCEDURE GetAirlineById
    @idAirline INT
AS
BEGIN

    SELECT idAirline, [name],  motto
    FROM  Airline
    WHERE idAirline = @idAirline;
END;
GO


CREATE OR ALTER PROCEDURE UpdateAirline
    @idAirline INT,
    @name VARCHAR(255),
    @motto VARCHAR(255)
AS 
BEGIN
    UPDATE Airline
    SET [name] = @name, motto = @motto
    WHERE idAirline = @idAirline
END;
GO  

CREATE OR ALTER PROCEDURE UpdatePlane
    @registrationNumber VARCHAR(50),
    @idAirline INT,
    @idBrand INT,
    @capacity INT
AS 
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        UPDATE Plane
        SET idAirline = @idAirline, idBrand = @idBrand, capacity = @capacity
        WHERE registrationNumber = @registrationNumber;

        COMMIT TRANSACTION;
        SELECT @@ROWCOUNT AS RowsAffected;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO


CREATE OR ALTER PROCEDURE GetPlaneByRegistrationNumber
    @registrationNumber VARCHAR(50)
AS 
BEGIN
    SELECT p.registrationNumber, a.name AS Airline, b.name AS Brand, p.capacity
    FROM Plane p
    INNER JOIN Airline a ON p.idAirline = a.idAirline
    INNER JOIN Brand b ON p.idBrand = b.idBrand
    WHERE p.registrationNumber = @registrationNumber;
END;
GO

CREATE OR ALTER PROCEDURE GetPlanesByAirline
AS
BEGIN
    SELECT a.name AS AirlineName, COUNT(p.registrationNumber) AS PlaneCount
    FROM Airline a
    LEFT JOIN Plane p ON a.idAirline = p.idAirline
    GROUP BY a.name
    ORDER BY PlaneCount DESC;
END;
GO

-- Visualización de datos
CREATE VIEW ActiveFlightsInfo AS
SELECT
	idFlight,
    CONCAT(A.idAirline, '; ', A.name) AS AirlineName,
CREATE OR ALTER PROCEDURE GetPlanesByCity
    @AirlineId INT = NULL
AS
BEGIN
    SELECT 
        C.name AS CityName,
        COUNT(DISTINCT F.registrationNumber) AS PlaneCount
    FROM 
        Flight F
    JOIN 
        City C ON F.arrivalCityCode = C.cityCode
    JOIN 
        Plane P ON F.registrationNumber = P.registrationNumber
    LEFT JOIN 
        Airline A ON P.idAirline = A.idAirline
    WHERE 
        (@AirlineId IS NULL OR A.idAirline = @AirlineId)
    GROUP BY 
        C.name
    ORDER BY 
        C.name;
END
GO

-- Visualizaci�n de datos
CREATE OR ALTER VIEW ActiveFlightsInfo AS
SELECT 
    A.name AS AirlineName,
    F.registrationNumber AS RegistrationNumber,
    CONCAT(P.idPilot, '; ' , P.name, ' ', P.lastName1, ' ', P.lastName2) AS PilotFullName,
    F.departureDateTime AS DepartureDate,
    F.arrivalDateTime AS ArrivalDate,
    CONCAT('(', DC.cityCode, ') ', DC.name) AS DepartureCity,
    CONCAT('(', AC.cityCode, ') ', AC.name) AS ArrivalCity
FROM 
    Flight F
    INNER JOIN Plane PL ON F.registrationNumber = PL.registrationNumber
    INNER JOIN Pilots P ON F.idPilot = P.idPilot
    INNER JOIN City DC ON F.departureCityCode = DC.cityCode
    INNER JOIN City AC ON F.arrivalCityCode = AC.cityCode
    INNER JOIN Airline A ON PL.idAirline = A.idAirline
WHERE 
    F.cancelled = 0;
GO

CREATE OR ALTER PROCEDURE GetTotalFlightHoursByAirline
AS
BEGIN
    SELECT 
        (SELECT name FROM Airline WHERE idAirline = a.idAirline) AS AirlineName,
        SUM(DATEDIFF(HOUR, f.departureDateTime, f.arrivalDateTime)) AS [TotalFlightHours]
    FROM Flight f
    INNER JOIN Plane p ON f.registrationNumber = p.registrationNumber
    RIGHT JOIN Airline a ON p.idAirline = a.idAirline
    WHERE f.cancelled = 0
    GROUP BY a.idAirline
    ORDER BY TotalFlightHours DESC;
END;
GO

CREATE OR ALTER PROCEDURE GetActiveFlightsByDateRange
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SELECT 
		idFlight,
        AirlineName,
        RegistrationNumber,
        PilotFullName,
        DepartureDate,
        ArrivalDate,
        DepartureCity,
        ArrivalCity
    FROM 
        ActiveFlightsInfo
    WHERE 
        DepartureDate BETWEEN @StartDate AND @EndDate
        AND ArrivalDate BETWEEN @StartDate AND @EndDate;
END;
GO

CREATE OR ALTER PROCEDURE GetCancelledFlights
AS
BEGIN
	SELECT 
		A.name AS AirlineName,
		F.registrationNumber AS RegistrationNumber,
		CONCAT(P.name, ' ', P.lastName1, ' ', P.lastName2) AS PilotFullName,
		F.departureDateTime AS DepartureDate,
		F.arrivalDateTime AS ArrivalDate,
		CONCAT('(', DC.cityCode, ') ', DC.name) AS DepartureCity,
		CONCAT('(', AC.cityCode, ') ', AC.name) AS ArrivalCity
	FROM 
		Flight F
		INNER JOIN Plane PL ON F.registrationNumber = PL.registrationNumber
		INNER JOIN Pilots P ON F.idPilot = P.idPilot
		INNER JOIN City DC ON F.departureCityCode = DC.cityCode
		INNER JOIN City AC ON F.arrivalCityCode = AC.cityCode
		INNER JOIN Airline A ON PL.idAirline = A.idAirline
	WHERE 
		F.cancelled = 1;
END;
GO

CREATE OR ALTER FUNCTION GetAirlineFlightInfoById
(
    @idAirline INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        A.name,
        F.idFlight,
        (
            SELECT CONCAT('(', DC.cityCode, ') ', DC.name)
            FROM City DC
            WHERE DC.cityCode = F.departureCityCode
        ) AS DepartureCity,
        (
            SELECT CONCAT('(', AC.cityCode, ') ', AC.name)
            FROM City AC
            WHERE AC.cityCode = F.arrivalCityCode
        ) AS ArrivalCity,
        F.departureDateTime,
        F.arrivalDateTime
    FROM 
        Flight F
    INNER JOIN 
        Plane P ON F.registrationNumber = P.registrationNumber
    INNER JOIN 
        Airline A ON P.idAirline = A.idAirline
    WHERE 
        A.idAirline = @idAirline
);
GO

CREATE OR ALTER PROCEDURE GetFlightInfo
    @idAirline INT
AS
BEGIN
    SELECT name, idFlight, DepartureCity, ArrivalCity, DepartureDateTime, ArrivalDateTime  
    FROM GetAirlineFlightInfoById(@idAirline);
END;

CREATE PROCEDURE UpdateFlightById
    @idFlight INT,
    @registrationNumber VARCHAR(50),
    @idPilot INT,
    @departureDateTime DATETIME,
    @arrivalDateTime DATETIME,
    @departureCityCode VARCHAR(3),
    @arrivalCityCode VARCHAR(3),
    @cancelled BIT
AS
BEGIN
    UPDATE Flight
    SET
        registrationNumber = @registrationNumber,
        idPilot = @idPilot,
        departureDateTime = @departureDateTime,
        arrivalDateTime = @arrivalDateTime,
        departureCityCode = @departureCityCode,
        arrivalCityCode = @arrivalCityCode,
        cancelled = @cancelled
    WHERE
        idFlight = @idFlight;
END;

CREATE PROCEDURE CancelFlightById
    @idFlight INT
AS
BEGIN
    UPDATE Flight
    SET
        cancelled = 1
    WHERE
        idFlight = @idFlight;
END;
GO


CREATE PROCEDURE GetUniquePlanesByRoute
AS
BEGIN
    SELECT 
        departureCityCode, 
        arrivalCityCode, 
        COUNT(DISTINCT registrationNumber) AS UniquePlanesCount
    FROM 
        Flight
    GROUP BY 
        departureCityCode, 
        arrivalCityCode
END;
GO

CREATE PROCEDURE GetFlightStatistics
AS
BEGIN
    SELECT 
        COUNT(DISTINCT p.registrationNumber) AS PlaneCount,
        COUNT(f.idFlight) AS FlightCount,
        c.name AS CityName
    FROM Flight f
    JOIN City c ON f.arrivalCityCode = c.cityCode
    JOIN Plane p ON f.registrationNumber = p.registrationNumber
    GROUP BY c.name
    ORDER BY FlightCount DESC;
END
GO

CREATE PROCEDURE GetFlightsByPlane
AS
BEGIN
    DECLARE @CurrentDate DATETIME = GETDATE();

    SELECT 
        P.registrationNumber,
        B.name,
        COUNT(F.idFlight) AS NumberOfFlights
    FROM 
        Flight F
    INNER JOIN 
        Plane P ON F.registrationNumber = P.registrationNumber
    INNER JOIN 
        Brand B ON P.idBrand = B.idBrand
    WHERE 
        F.arrivalDateTime < @CurrentDate
        AND F.cancelled = 0
    GROUP BY 
        P.registrationNumber, B.name;
END;


