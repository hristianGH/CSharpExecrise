CREATE DATABASE CarRental
GO
USE CarRental
GO
CREATE TABLE Country

(
 Id int Primary Key Identity,
 Name VARCHAR(100)
)
GO
CREATE TABLE City

(
 Id INT PRIMARY KEY IDENTITY,
 Name VARCHAR(100)
)
GO
--CREATE TABLE [Location]
--(
--  CityId INT,
--  CountryId INT,
--  PRIMARY KEY (CityId,CountryId)
--)
GO
CREATE TABLE Agency
(
  Id INT PRIMARY KEY IDENTITY,
  Name VARCHAR(100),
  CityId INT,
)
GO
CREATE TABLE Cars
(
 Id INT PRIMARY KEY IDENTITY,
 [Year] DATE,
 Miles REAL,
 Color VARCHAR(30),
 CategoryId INT,
 AgencyId INT,
 Size VARCHAR(30)
)
GO
CREATE TABLE CarCategory
(
  Id INT PRIMARY KEY IDENTITY,
  Size VARCHAR(30)
)
CREATE TABLE Rental
(
  Id INT PRIMARY KEY IDENTITY,
  Price DECIMAL,
  AgencyId INT,
  CarId INT ,
  CustomerId INT
)
GO
CREATE TABLE Customer
(
  Id INT PRIMARY KEY IDENTITY,
  [Age] INT ,

)

GO
ALTER TABLE CITY
ADD CountryId INT 
FOREIGN KEY (CountryId)REFERENCES  COUNTRY(ID)
GO
ALTER TABLE AGENCY
ADD FOREIGN KEY (CityId)REFERENCES  CITY(ID)
GO
ALTER TABLE CARS
ADD FOREIGN KEY (AgencyId)REFERENCES  AGENCY(ID)
GO
 ALTER TABLE RENTAL
 ADD FOREIGN KEY (CarId)REFERENCES  CARS(ID)
 GO
 ALTER TABLE RENTAL
 ADD FOREIGN KEY (CustomerId)REFERENCES  CUSTOMER(ID)


CREATE TRIGGER AgeChecK
ON RENTAL
AFTER INSERT
 AS
DECLARE @Tax REAL
SET @Tax=(
 SELECT 
 CASE WHEN Age<25 OR AGE >75 
 THEN 1.3
 ELSE 1
 END
 FROM inserted I
 JOIN Customer C
 ON I.CustomerId=C.Id
 )
 UPDATE Rental
 SET Price=Price*@Tax;