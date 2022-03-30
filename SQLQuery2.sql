create database agendaa
go
use agendaa

create table contacto 
(
Id int identity (1,1) primary key,
 nvarchar (100),
Apellido nvarchar (100),
Direccion nvarchar (100),
telefoNombreno nvarchar (10),
fecha_nac date,
)

insert into contactos 
values
('Rosanna','Amparo','c/79 Distrito Nacional','8095267845','04-01-2002')

---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
go
create proc Mostrarcontacto
as
select *from contactos
go

--------------------------INSERTAR 
create proc Insertarcontacto
@nombre nvarchar (100),
@Apellido nvarchar (100),
@Direccion nvarchar (100),
@Telefono nvarchar (100),
@fecha_nac date
as
insert into contactos values (@nombre,@Apellido,@Direccion,@Telefono,@fecha_nac)
go

------------------------ELIMINAR
create proc EliminarContacto
@idpro int
as
delete from contactos where Id=@idpro
go
------------------EDITAR

create proc Editarcontacto
@Id int ,
@nombre nvarchar (100),
@Apellido nvarchar (100),
@Direccion nvarchar (100),
@Telefono nvarchar (100),
@fecha_nac date
as
update contactos set nombre=@nombre, Apellido=@Apellido, Direccion=@Direccion, telefono=@Telefono, fecha_nac=@fecha_nac where Id=@id
go