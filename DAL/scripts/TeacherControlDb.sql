﻿use TeacherControlDb
create table Usuario(
 usuarioId int identity(1,1),
 nombre varchar(30),
 apellido varchar(50),
 email varchar(50),
 direccion varchar(100),
 telefono varchar(15),
 clave varchar(15),
 confirmarClave Varchar(15),
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
		CursoId int,
		Grupo varchar(5),
		Email Varchar(70),
		Direccion varchar(100),
		--TutorId int foreign key References Tutores(TutorId),
		primary key(EstudianteId)
)
Go
create table Tutores(
		TutorId int identity(1,1) primary key,
		Nombre varchar(50),
		Apellido varchar(30),
		Cedula varchar(20),
		Genero VarChar(5),
		Email Varchar(70),
		Direccion varchar(100)
)
go
create table TutoresTelefonos(
	 id int identity(1,1) primary key,
	 TutorId int foreign key References Tutores(TutorId),
	 TipoId int,
	 Telefono varchar(15)
)
go
create table Cursos(
	CursoId int identity(1,1),
	DesCripcion varchar(50),
	 primary key(CursoId)
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
	   CursoId  int,
	   EstudianteId int, 
	   Accion varchar(12),
	   primary key(AsistenciaId)
) 
go
create table Calificaciones(
		CalificacionId int identity(1,1) primary key,
		EstudianteId int,
		MateriaId int, 
		Descripcion varchar(70),
		Puntuacion int
)
go
create table CalificaionesDetalle(
		CalificaionDetalleId int identity(1,1) primary key

)
go
create table Evaluaciones(
	EvaluacionId int identity(1,1) primary key,
	AsitenciaId int,
	CalificacionId int, 

)
go



SELECT * from Usuario
