USE AirlineControl;
GO

INSERT INTO Roles
	(idRole, name)
	VALUES
	(1, 'admin'),
	(2, 'reservas')

INSERT INTO AppUser
	(email, password, idRole)
	VALUES
	('dylanmmz01@gmail.com', 'Dylan123', 1);

INSERT INTO AppUser
    (email, password, idRole)
    VALUES
    ('1', '1', 1); -- for quick tests

INSERT INTO City
    (cityCode, name)
    VALUES
    -- USA Cities
    ('NYC', 'New York City'),
    ('LAX', 'Los Angeles'),
    ('CHI', 'Chicago'),
    ('HOU', 'Houston'),
    ('PHX', 'Phoenix'),
    ('SAN', 'San Diego'),
    ('DAL', 'Dallas'),
    ('SFO', 'San Francisco'),
    ('SEA', 'Seattle'),
    ('ATL', 'Atlanta'),
    ('MIA', 'Miami'),
    ('DEN', 'Denver'),
    ('BOS', 'Boston'),
    ('LAS', 'Las Vegas'),
    ('MSP', 'Minneapolis'),
    ('DTW', 'Detroit'),
    ('PHL', 'Philadelphia'),
    ('CLT', 'Charlotte'),
    ('AUS', 'Austin'),
    ('SLC', 'Salt Lake City'),
    -- Central America Cities
    ('GUA', 'Guatemala City'),
    ('SJO', 'San José'),
    ('TGU', 'Tegucigalpa'),
    ('SAP', 'San Pedro Sula'),
    ('SAL', 'San Salvador'),
    ('PTY', 'Panama City'),
    ('MGA', 'Managua'),
    ('BZE', 'Belize City'),
    ('LIR', 'Liberia'),
    ('RTB', 'Roatán'),
    -- Popular Cities across the world
    ('LON', 'London'),
    ('PAR', 'Paris'),
    ('BER', 'Berlin'),
    ('AMS', 'Amsterdam'),
    ('ROM', 'Rome'),
    ('MAD', 'Madrid'),
    ('BCN', 'Barcelona'),
    ('DUB', 'Dublin'),
    ('SYD', 'Sydney'),
    ('MEL', 'Melbourne'),
    ('BKK', 'Bangkok'),
    ('HKG', 'Hong Kong'),
    ('TYO', 'Tokyo'),
    ('SIN', 'Singapore'),
    ('DXB', 'Dubai'),
    ('JNB', 'Johannesburg'),
    ('CPT', 'Cape Town'),
    ('MEX', 'Mexico City'),
    ('GRU', 'Sao Paulo'),
    ('BUE', 'Buenos Aires');
GO

INSERT INTO Airline 
    (name, motto)
    VALUES
    ('American Airlines', 'Going for great'),
    ('Delta Air Lines', 'Keep Climbing'),
    ('United Airlines', 'Fly the Friendly Skies'),
    ('Southwest Airlines', 'Low fares. Nothing to hide.'),
    ('JetBlue Airways', 'You above all'),
    ('Alaska Airlines', 'Fly smart. Land happy.'),
    ('Spirit Airlines', 'Less Money. More Go.'),
    ('Frontier Airlines', 'Low Fares Done Right'),
    ('Allegiant Air', 'Together We Fly'),
    ('Hawaiian Airlines', 'The Spirit of Aloha');
GO

INSERT INTO Brand 
    (name)
    VALUES
    ('Boeing'),
    ('Airbus'),
    ('Embraer'),
    ('Bombardier'),
    ('Cessna'),
    ('Gulfstream'),
    ('Dassault'),
    ('Mitsubishi'),
    ('Sukhoi'),
    ('Comac');
GO

INSERT INTO Plane 
    (registrationNumber, idAirline, idBrand, capacity)
    VALUES
    ('N123AA', 1, 1, 200),  -- American Airlines, Boeing
    ('N456DL', 2, 2, 180),  -- Delta Air Lines, Airbus
    ('N789UA', 3, 1, 250),  -- United Airlines, Boeing
    ('N321SW', 4, 2, 150),  -- Southwest Airlines, Airbus
    ('N654JB', 5, 3, 160),  -- JetBlue Airways, Embraer
    ('N987AS', 6, 1, 220),  -- Alaska Airlines, Boeing
    ('N321NK', 7, 2, 190),  -- Spirit Airlines, Airbus
    ('N654F9', 8, 1, 170),  -- Frontier Airlines, Boeing
    ('N987G4', 9, 3, 130),  -- Allegiant Air, Embraer
    ('N321HA', 10, 4, 240), -- Hawaiian Airlines, Bombardier
    ('N654AA', 1, 2, 210),  -- American Airlines, Airbus
    ('N321DL', 2, 1, 200),  -- Delta Air Lines, Boeing
    ('N987UA', 3, 3, 160),  -- United Airlines, Embraer
    ('N123SW', 4, 1, 140),  -- Southwest Airlines, Boeing
    ('N456JB', 5, 2, 190),  -- JetBlue Airways, Airbus
    ('N789AS', 6, 3, 180),  -- Alaska Airlines, Embraer
    ('N322NK', 7, 4, 220),  -- Spirit Airlines, Bombardier
    ('N654F8', 8, 2, 170),  -- Frontier Airlines, Airbus
    ('N987G3', 9, 4, 150),  -- Allegiant Air, Bombardier
    ('N321HB', 10, 1, 230), -- Hawaiian Airlines, Boeing
    ('N654BB', 1, 5, 50),   -- American Airlines, Cessna
    ('N321CC', 2, 6, 80),   -- Delta Air Lines, Gulfstream
    ('N987DD', 3, 7, 100),  -- United Airlines, Dassault
    ('N123EE', 4, 8, 120),  -- Southwest Airlines, Mitsubishi
    ('N456FF', 5, 9, 140),  -- JetBlue Airways, Sukhoi
    ('N789GG', 6, 10, 160), -- Alaska Airlines, Comac
    ('N321HH', 7, 5, 60),   -- Spirit Airlines, Cessna
    ('N654II', 8, 6, 90),   -- Frontier Airlines, Gulfstream
    ('N987JJ', 9, 7, 110),  -- Allegiant Air, Dassault
    ('N321KK', 10, 8, 130); -- Hawaiian Airlines, Mitsubishi
GO

-- testeando unas cosillas del modulo de pasajero
INSERT INTO Pilots
    (name, lastName1, lastName2, email, phoneNumber, idAirline)
    VALUES
    ('Pedro', 'Pascal', 'Hernandez', 'email@email.com', '88882288', 9)

INSERT INTO Flight
    (registrationNumber, idPilot, departureDateTime, arrivalDateTime, departureCityCode, arrivalCityCode, cancelled)
    VALUES
    ('N987G4', 1, DATEADD(HOUR, 2, CURRENT_TIMESTAMP), DATEADD(HOUR, 5, CURRENT_TIMESTAMP), 'SJO', 'GUA', 0),
    ('N987G3', 1, DATEADD(HOUR, 6, CURRENT_TIMESTAMP), DATEADD(HOUR, 8, CURRENT_TIMESTAMP), 'SJO', 'GUA', 0),
    ('N987JJ', 1, DATEADD(HOUR, 32, CURRENT_TIMESTAMP), DATEADD(HOUR, 36, CURRENT_TIMESTAMP), 'SJO', 'GUA', 0)

INSERT INTO Passengers
    (passportNumber, name, lastName1, lastName2, email, phoneNumber)
    VALUES
    ('PS1234', 'John', 'Walker', 'Espinoza', 'mail@mail.com', '87676556')

GO

INSERT INTO Pilots 
	(name, lastName1, lastName2, email, phoneNumber, idAirline)
VALUES 
	('John', 'Doe', 'Smith', 'john.doe@gmail.com', '12345678', 1),
	('Jane', 'Roe', 'Johnson', 'jane.roe@gmail.com', '87654321', 2),
	('Mike', 'Brown', 'Williams', 'mike.brown@gmail.com', '23456789', 3),
	('Emily', 'Davis', 'Jones', 'emily.davis@gmail.com', '98765432', 4),
	('David', 'Garcia', 'Miller', 'david.garcia@gmail.com', '34567890', 5),
	('Sophia', 'Martinez', 'Rodriguez', 'sophia.martinez@gmail.com', '76543210', 6),
	('Chris', 'Hernandez', 'Martinez', 'chris.hernandez@gmail.com', '45678901', 7),
	('Anna', 'Lopez', 'Gonzalez', 'anna.lopez@gmail.com', '65432109', 8),
	('James', 'Wilson', 'Perez', 'james.wilson@gmail.com', '56789012', 9),
	('Linda', 'Anderson', 'Sanchez', 'linda.anderson@gmail.com', '54321098', 10),
	('Robert', 'Thomas', 'Ramirez', 'robert.thomas@gmail.com', '67890123', 1),
	('Patricia', 'Taylor', 'Flores', 'patricia.taylor@gmail.com', '43210987', 2),
	('Michael', 'Moore', 'Gonzales', 'michael.moore@gmail.com', '78901234', 3),
	('Barbara', 'Jackson', 'Hernandez', 'barbara.jackson@gmail.com', '32109876', 4),
	('William', 'Martin', 'Robinson', 'william.martin@gmail.com', '89012345', 5);

INSERT INTO Flight
    (registrationNumber, idPilot, departureDateTime, arrivalDateTime, departureCityCode, arrivalCityCode, cancelled)
    VALUES
    -- Vuelos de American Airlines (AirlineId = 1)
    ('N123AA', 1, '2023-06-01 08:00:00', '2023-06-01 12:00:00', 'NYC', 'LAX', 0),
    ('N654AA', 1, '2023-06-02 09:00:00', '2023-06-02 13:00:00', 'LAX', 'CHI', 0),
    -- Vuelos de Delta Air Lines (AirlineId = 2)
    ('N456DL', 2, '2023-06-03 10:00:00', '2023-06-03 14:00:00', 'NYC', 'HOU', 0),
    ('N321DL', 2, '2023-06-04 11:00:00', '2023-06-04 15:00:00', 'HOU', 'PHX', 0),
    -- Vuelos de United Airlines (AirlineId = 3)
    ('N789UA', 3, '2023-06-05 12:00:00', '2023-06-05 16:00:00', 'PHX', 'SAN', 0),
    ('N987UA', 3, '2023-06-06 13:00:00', '2023-06-06 17:00:00', 'SAN', 'DAL', 0),
    -- Vuelos de Southwest Airlines (AirlineId = 4)
    ('N321SW', 4, '2023-06-07 14:00:00', '2023-06-07 18:00:00', 'DAL', 'SFO', 0),
    ('N123SW', 4, '2023-06-08 15:00:00', '2023-06-08 19:00:00', 'SFO', 'SEA', 0),
    -- Vuelos de JetBlue Airways (AirlineId = 5)
    ('N654JB', 5, '2023-06-09 16:00:00', '2023-06-09 20:00:00', 'SEA', 'ATL', 0),
    ('N456JB', 5, '2023-06-10 17:00:00', '2023-06-10 21:00:00', 'ATL', 'MIA', 0),
    -- Vuelos de Alaska Airlines (AirlineId = 6)
    ('N987AS', 6, '2023-06-11 18:00:00', '2023-06-11 22:00:00', 'MIA', 'DEN', 0),
    ('N789AS', 6, '2023-06-12 19:00:00', '2023-06-12 23:00:00', 'DEN', 'BOS', 0),
    -- Vuelos de Spirit Airlines (AirlineId = 7)
    ('N321NK', 7, '2023-06-13 20:00:00', '2023-06-14 00:00:00', 'BOS', 'LAS', 0),
    ('N322NK', 7, '2023-06-14 21:00:00', '2023-06-15 01:00:00', 'LAS', 'MSP', 0),
    -- Vuelos de Frontier Airlines (AirlineId = 8)
    ('N654F9', 8, '2023-06-15 22:00:00', '2023-06-16 02:00:00', 'MSP', 'DTW', 0),
    ('N654F8', 8, '2023-06-16 23:00:00', '2023-06-17 03:00:00', 'DTW', 'PHL', 0),
    -- Vuelos de Allegiant Air (AirlineId = 9)
    ('N987G4', 9, '2023-06-17 06:00:00', '2023-06-17 10:00:00', 'PHL', 'CLT', 0),
    ('N987G3', 9, '2023-06-18 07:00:00', '2023-06-18 11:00:00', 'CLT', 'AUS', 0),
    -- Vuelos de Hawaiian Airlines (AirlineId = 10)
    ('N321HA', 10, '2023-06-19 08:00:00', '2023-06-19 12:00:00', 'AUS', 'SLC', 0),
    ('N321HB', 10, '2023-06-20 09:00:00', '2023-06-20 13:00:00', 'SLC', 'NYC', 0);
GO