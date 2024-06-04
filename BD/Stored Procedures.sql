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




