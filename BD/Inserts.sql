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