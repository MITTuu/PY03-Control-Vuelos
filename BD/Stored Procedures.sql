USE AirlineControl;

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

-- Stored procedures Flights
CREATE PROCEDURE GetAirlines
AS
BEGIN
	SELECT idAirline, name, motto
	FROM Airline
END;

CREATE PROCEDURE GetPlaneByIdAirline
	@idAirline INT
AS
BEGIN
	SELECT p.registrationNumber, b.name, p.capacity
	FROM Plane p
	INNER JOIN Brand b ON b.idBrand = p.idBrand
	WHERE p.idAirline = @idAirline
END;

CREATE PROCEDURE GetPilotsByIdAirline
	@idAirline INT
AS
BEGIN
	SELECT idPilot, name, lastName1, lastName2, email, phoneNumber
	FROM Pilots
	WHERE idAirline = @idAirline
END;

CREATE PROCEDURE GetCities
AS
BEGIN
	SELECT cityCode, name
	FROM City
END;

CREATE PROCEDURE isPilotAvailable
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
        SELECT 1 AS IsPilotBusy; -- El piloto está ocupado en ese rango de fechas
    END
    ELSE
    BEGIN
        SELECT 0 AS IsPilotBusy; -- El piloto no está ocupado en ese rango de fechas
    END
END;

CREATE PROCEDURE InsertFlight
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