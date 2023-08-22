Create Database Biblioteca 

Use Biblioteca


create table Libro (
idlibro int identity,
--Datos de tabla que ve el cliente
Titulo nvarchar,
Autor nvarchar,
ISBN int,
Cantidad_de_paginas int,
Edicion int,
Editorial nvarchar,
Lugar nvarchar,
FechaEdicion nvarchar,
Primary key (idlibro),
)