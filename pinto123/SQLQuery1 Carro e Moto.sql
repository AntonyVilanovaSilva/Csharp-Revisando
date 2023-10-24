use master
go
create database Concessionaria
use Concessionaria
go

create table Carros(
car_id int identity (1,1) primary key,
car_modelo varchar(500),
car_ano varchar(500),
car_cor varchar(500)

)

Insert Carros(car_modelo,car_ano,car_cor) values ('Fiat','2022','Vermelho')

select  * from Carros

create table Motos(
mot_id int identity (1,1) primary key,
mot_modelo varchar(500),
mot_ano varchar(500),
mot_cor varchar(500)
)

Insert Motos(mot_modelo,mot_ano,mot_cor) values ('Honda','2005','Preto')

select  * from Motos


Create table Caminhao(
cam_id int identity (1,1) primary key,
cam_modelo varchar(500),
cam_ano varchar(500),
cam_cor varchar(500)
)


Insert Caminhao(cam_modelo,cam_ano,cam_cor) values ('Mercedes-1620','2005','Vermelho')

select * from Caminhao