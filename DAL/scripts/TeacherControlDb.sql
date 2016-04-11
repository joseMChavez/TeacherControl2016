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
CREATE TABLE Grupos(
  GrupoId int identity(1,1),
  Descripcion varchar(10),
  primary key(GrupoId)
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
	   Curso int,
	   CursoGrupo varchar(5),
	   Fecha DateTime,
	   CantidaEst int,
	   
	   primary key(AsistenciaId)
) 
go
Create table AsistenciaDetalle(
 Id int identity(1,1),
 Estudiante varchar(100), 
 Matricula int,
 AsistenciaId int foreign key references Asistencias(AsistenciaId),
 Activo varchar(15),
 primary key(Id)
)
go
create table Calificaciones(
		CalificacionId int identity(1,1) primary key,
		Estudiante varchar(50), 
		Materia varchar(20), 
	    Curso varchar(20),
	    Cursogrupo varchar(5),
		TotalPuntos float,
	    Fecha DateTime	
)
go
create table CalificacionDetalle(
		Id int identity(1,1) primary key,
		CalificacionId int foreign key references Calificaciones(CalificacionId),
		Descripcion varchar(70),
		Puntuacion float
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
select * from  AsistenciaDetalle;
select * From Estudiante
Insert Into Asistencias(Curso,CursoGrupo,Fecha) values(1,'C','2016-03-31 09:21:32 PM',1) ;
Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values(5,'Jose','Presente')
select A.AsistenciaId as Id,A.Curso, A.CursoGrupo as Grupo,AD.EstudianteId as Estudiante,AD.Activo as Estado, A.Fecha from Asistencias as  A Inner join AsistenciaDetalle as AD ON A.AsistenciaId=AD.AsistenciaId;