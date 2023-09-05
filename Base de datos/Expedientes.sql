

USE Expediente

CREATE TABLE Expediente (
	
---CREANDO TABLAS
create table Pacientes 
(
  NExpediente int primary key IDENTITY not null,
  IdExpedienteBIT int not null,
  FechaIngreso date not null,
  FechaModificado date not null,
  usuarioCreo int,
  usuarioModificado int
)

create table Hoja 
(
  IdHoja int primary key IDENTITY not null,
  HojaAgregada varbinary(max) null,
  usuarioCreo int,
  usuarioModificado int,
   FechaIngreso date not null,
  FechaModificado date not null
  )
 
  create table Usuarios
  (
	IdUsuario int primary key IDENTITY not null,
	Usuario varchar(50) not null,
	Contra varchar(50) not null,
	FechaIngreso date not null,
	FechaModificado date not null,
	IdEstado int  not null,
	IdTipoUsuario int not null
  )

  create table EstadoUsuario
  (
	IdEstado int primary key IDENTITY not null,
	EstadoUsuario varchar(50) not null
  )

  create table TipoUsuario 
  (
  IdTipoUsuario int primary key IDENTITY not null,
  TipoUsuario varchar(50) not null
  )


  --Creando Tabla transaccional
  
  create table Expedientes 
(
  IdNExpediente int primary key IDENTITY references Pacientes,
  IdHoja int primary key IDENTITY references Hoja,
  Observaciones varchar(80) not null
 )