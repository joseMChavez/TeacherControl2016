create table Usuario(
 usuarioId int identity(1,1),
 nombre varchar(30),
 clave varchar(15),
 tipoUsuario varchar(20),
 primary key(usuarioId)
);