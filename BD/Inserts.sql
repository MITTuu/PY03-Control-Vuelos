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