CREATE TABLE Usuarios
(
	[usuarioId] INT identity PRIMARY KEY, 
    [nombre] VARCHAR(50) NOT NULL, 
    [clave] VARCHAR(15) NOT NULL, 
    [tipoUsuario] VARCHAR(20) NOT NULL
)
