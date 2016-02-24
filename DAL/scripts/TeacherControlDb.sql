create table Usuario(
 usuarioId int identity(1,1),
 nombre varchar(30),
 clave varchar(15),
 tipoUsuario varchar(20),
 primary key(usuarioId)
) 
Go
Create table Estudiantes( 
		EstudianteId int identity(1,1),
		Matricula int,
		Nombre varchar(50),
		Apellido varchar(30),
		Genero VarChar(5),
		FechaNacimiento varchar(20),
		Celular varchar(15),
		Email Varchar(70),
		Direccion varchar(100),
		TutorId int,
		primary key(EstudianteId)
)
Go