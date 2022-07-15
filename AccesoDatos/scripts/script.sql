create database Roles

use Roles

CREATE TABLE ROLES(
	[id] [int] IDENTITY(1,1) primary key NOT NULL,
	[nombre] [varchar](50) NOT NULL
);

insert into roles 
(nombre) values ('recepcionista');

insert into roles 
(nombre) values ('medico');

insert into roles 
(nombre) values ('administrador');





insert into roles
(nombre) values ('paciente');

create table PERSONAS(
   
   id int IDENTITY(1,1) primary key, 
   id_ciudad int null,
   id_rol int null,
   nombre varchar (50) null,
   apellido varchar (50) null,
   dni smallint not null check (dni > 0),
   cuit varchar (11) not null unique,
   telefono varchar (20) null,
   fecha_nacimiento date not null,
   direccion varchar (50) null,
   email varchar (50) unique not null,
   clave varchar (20) not null,
   
);

create table PACIENTES (

   id_persona int unique not null,
   id_turno int null,
   
);

ALTER TABLE PACIENTES

 ADD CONSTRAINT FK_Pacientes_Personas FOREIGN KEY([id_persona]) 
    REFERENCES [PERSONAS]([id]);


ALTER TABLE PERSONAS
ADD FOREIGN KEY (id_rol) REFERENCES ROLES(id);


insert into PERSONAS
(id_ciudad,id_rol,nombre,apellido,dni,cuit,fecha_nacimiento,email,clave)

values (1,4,'Roberto','Herrera',111,'20334446661','12/11/1990','roberto@gmail.com','rober1234')


insert into pacientes
(id_persona,id_turno) values (4,1)
