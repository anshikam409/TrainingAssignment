create database normalization_exercise

use normalization_exercise

--Applying 1NF in database normalization_exercise table name ClientRental
create table ClientRental(
ClientNo varchar(225),
CName varchar(225),
PropertyNo varchar(225),
PAddress varchar(225),
RentStart date,
RentFinish date,
Rent int,
OwnerNo varchar(225),
Oname varchar(225)
)

--Inserting values in the table ClientRental
Insert into ClientRental values
('CR76','John Kay','PG4','6 Lawrence','2003-07-09','2001-09-01',350,'C040','Tina Murphy'),
('CR76','John Kay','PG16','5 Novar Dr Glass Grow','2001-09-02','2001-09-02',450,'C093','Tony Shaw'),
('CR56','Aline Stewart','PG4','6 Lawrence','1999-09-01','2000-09-01',350,'C040','Tina Murphy'),
('CR56','Aline Stewart','PG36','2 Manor Rd,Glass Gow','2000-10-10','2001-12-01',370,'C093','Tony Shaw'),
('CR56','Aline Stewart','PG16','5 Novar Dr Glass Grow','2002-11-01','2003-08-01',450,'C093','Tony Shaw')

select* from ClientRental

--Applying 2NF in database normalization_exercise and creating table client,property and rental

--creating table client
create table Client(
    ClientNo varchar(255) primary key,
    CName varchar(255)
)

--inserting values in table client
insert into Client values
('CR76', 'John Kay'),
('CR56', 'Aline Stewart')

--select client table
select* from Client

--create table property
create table Property (
    PropertyNo varchar(255) primary key,
    PAddress varchar(255),
    OwnerNo varchar(255),
    OName varchar(255)
)

 --inserting values in table property

insert into Property values
('PG4','6 Lawrence', 'CO40', 'Tina Murphy'),
('PG16','5 Novar Dr Glass Grow', 'CO93', 'Tony Shaw'),
('PG36','2 Manor Rd, Glass Gow', 'CO93', 'Tony Shaw')

 --select table property
 select* from property

 --creating table rental

create table Rental (
    ClientNo varchar(255) references Client(ClientNo),
    PropertyNo varchar(255) references Property(PropertyNo),
    RentStart date,
    RentFinish date,
    Rent int,
    primary key (ClientNo, PropertyNo)
)

--inserting values in table rental
insert into rental values
('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
('CR56', 'PG16', '2002-11-01', '2003-08-01', 450)

--select table rental
select* from rental

--Applying 3NF in database normalization_exercise and creating table clients,PropertyOwners,properties and rentals

--creating table client
create table Clients(
    ClientNo varchar(255) primary key,
    CName varchar(255)
)

 --inserting values in table clients

insert into clients values
('CR76', 'John Kay'),
('CR56', 'Aline Stewart')

--select table clients
select* from clients
 
 --creating table PropertyOwners

create table PropertyOwners (
    OwnerNo varchar(255) primary key,
    OName varchar(255)
)

 --insert values in table PropertyOwners
insert into PropertyOwners values
('CO40', 'Tina Murphy'),
('CO93', 'Tony Shaw')

--select table property owners
select* from PropertyOwners

--create table Properties 

CREATE TABLE Properties(
    PropertyNo varchar(255) primary key,
    PAddress varchar(255),
    OwnerNo VARCHAR(255) references PropertyOwners(OwnerNo)
)

 --inserting values in table properties
insert into Properties values
('PG4', '6 Lawrence', 'CO40'),
('PG16', '5 Novar Dr Glass Grow', 'CO93'),
('PG36', '2 Manor Rd, Glass Gow', 'CO93');

--select table properties
select* from properties

 --create table rentals
create table Rentals (
    ClientNo varchar(255),
    PropertyNo varchar(255),
    RentStart DATE,
    RentFinish DATE,
    Rent int,
    PRIMARY KEY (ClientNo, PropertyNo),
    FOREIGN KEY (ClientNo) REFERENCES Clients(ClientNo),
    FOREIGN KEY (PropertyNo) REFERENCES Properties(PropertyNo)
)

 --insert values in table Rentals

insert into Rentals values
('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
('CR56', 'PG16', '2002-11-01', '2003-08-01', 450)

--select table Rentals
select* from rentals