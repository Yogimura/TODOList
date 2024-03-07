create database TODO

use TODO

create table Tasks(
ID int primary key identity not null,
Titulo varchar(50) not null,
Descripcion varchar(255) not null,
Estado bit not null,
)

insert into Tasks values('Regas las plantas', 'regar 5 plantas', 0)
insert into Tasks values ('Limpiar el patio', 'Limpiar el patio delantero', 1)

select * from Tasks