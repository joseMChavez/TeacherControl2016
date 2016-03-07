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
	Descripcion varchar(50),
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
		Genero int,
		FechaNacimiento varchar(20),
		Edad int,
		Celular varchar(15),
		Email Varchar(70),
		Direccion varchar(100),
		CursoId int Foreign key References Cursos(CursoId),
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
		CalificaionDetalleId int identity(1,1) primary key,


)
go
create table Evaluaciones(
	EvaluacionId int identity(1,1) primary key,
	AsitenciaId int,
	CalificacionId int, 

)
go
Drop table  Cursos;
Select * From CursosDetalle
insert into Usuario(nombre,apellido,email,direccion,telefono,clave,confirmarClave) Values('Jose','Carlos','Gimenez','hj','809-844-2216','123345','123345')