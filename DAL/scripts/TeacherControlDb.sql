use [C:\USERS\JOSE\SOURCE\REPOS\TEACHERCONTROL2016\TEACHERCONTROL2016\DATABASE\TEACHERCONTROLDB.MDF]
go
create table Usuario(
 usuarioId int identity(1,1),
 nombre varchar(50),
 apellido varchar(50),
 email varchar(100),
 direccion varchar(100),
 clave varchar(15),
 confirmarClave Varchar(15),
 primary key(usuarioId)
) 
Go
create table Curso(
	CursoId int identity(1,1),
	Descripcion varchar(50),
	 primary key (CursoId) 
)
go
Create table CursosDetalle(
	Id  int identity(1,1),
	Grupo varchar(5),
	Curso int Foreign key References Curso(CursoId) ,
	Nombre varchar(50),
	Apellidos varchar(50),
	Matricula int,
    primary key (Id)
)
go
Create table Estudiante( 
		EstudianteId int identity(1,1),
		Matricula int,
		Nombre varchar(50),
		Apellido varchar(50),
		Genero Varchar(3),
		FechaNacimiento varchar(20),
		Edad int,
		Celular varchar(15),
		Email Varchar(70),
		Direccion varchar(100),
		CursoId int Foreign key References Curso(CursoId),
		Grupo varchar(10),
		NombrePadre varchar(50),
		TelefonoPadre varchar(15),
		primary key(EstudianteId)
)

go
create table Materias(
        MateriaId int identity(1,1),
		Descripcion varchar(100),
		primary key(MateriaId)
)
go
create table Asistencias(
       AsistenciaId int identity(1,1),
	   CursoId  int foreign key references Curso(CursoId),
	   Cursogrupo varchar(5),
	   Fecha varchar(15),
	   primary key(AsistenciaId)
) 
go
Create table AsistenciaDetalle(
 Id int identity(1,1),
 EstudianteId int foreign key references Estudiante(EstudianteId), 
 AsistenciaId int foreign key references Asistencias(AsistenciaId),
 Activo varchar(15),
 primary key(Id)
)
go
create table Calificaciones(
		CalificacionId int identity(1,1) primary key,
		EstudianteId int foreign key references Estudiante(EstudianteId), 
		MateriaId int foreign key references Materias(MateriaId), 
	    CursoId  int foreign key references Curso(CursoId),
	    Cursogrupo varchar(5),
	    Fecha varchar(15),
		
)
go
create table CalificacionDetalle(
		Id int identity(1,1) primary key,
		CalificacionId int foreign key references Calificaciones(CalificacionId),
		Descripcion varchar(70),
		Puntuacion int

)
go
create table Evaluaciones(
	EvaluacionId int identity(1,1) primary key,
	AsitenciaId int,
	CalificacionId int,
)
go
CREATE TABLE CategoriaCalificaciones
(
	CategoriaCalificacionesId INT identity(1,1) NOT NULL PRIMARY KEY, 
    Descripcion VARCHAR(100) NOT NULL
)

go
drop table CalificacionDetalle;
select * From CalificacionDetalle