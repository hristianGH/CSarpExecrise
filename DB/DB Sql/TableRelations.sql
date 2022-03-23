--CREATE DATABASE [Table Relations]

 --Problem 1.	One-To-One Relationship

--CREATE TABLE Persons 
--(
--  PersonID int IDENTITY Primary key,
--  [FirstName] VARCHAR(16) NOT NULL,
--  SALARY REAL ,
--  PassportID int,
--  FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)
--)
--GO
--CREATE TABLE Passports
--(
--  PassportID int Primary Key,
--  [Passport Number] varchar(8)
--)
--GO

--Problem 2.	One-To-Many Relationsh

--INSERT INTO Passports (PassportID,[Passport Number])
--VALUES 
-- (101,	'N34FG21B'),
-- ( 102,	'K65LO4R7'),
-- ( 103,'ZE657QP2')

-- INSERT INTO Persons(	FirstName,	Salary	,PassportID)
-- VALUES
 
--('Roberto' ,43300.00	,102),
--('Tom',56100.00,	103	),
--('Yana',60200.00	,101)
						 
--CREATE TABLE Models
--(
--ModelID INT IDENTITY PRIMARY KEY 
--,[Name] VARCHAR(30) 
--,ManufacturerID INT
--,FOREIGN KEY (ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
--)
--GO
--CREATE TABLE Manufacturers
--(
--ManufacturerID INT IDENTITY PRIMARY KEY,
--[Name] VARCHAR(30),
--EstablishedOn DATE
--)
--GO

--INSERT INTO Manufacturers([Name],EstablishedOn)
--VALUES
--('BMW',	'07/03/1916' ),
--('Tesla','01/01/2003' ),
--('Lada','01/05/1966' )
--GO

--SET IDENTITY_INSERT MODELS  ON
--GO

--INSERT INTO Models(MODELID,[Name],[ManufacturerID])
--VALUES 
--(101,'X1',1		),
--(102,'i6',1		),
--(103,'Model S',2),
--(104,'Model X',2),
--(105,'Model 3',2),
--(106,'Nova',3	)

--Problem 3.	Many-To-Many Relationship

--CREATE TABLE Students
--(
--StudentID INT IDENTITY PRIMARY KEY,
--[Name] VARCHAR(24)
--)
--GO
--CREATE TABLE Exams
--(
-- ExamID INT IDENTITY PRIMARY KEY,	
-- [Name] VARCHAR(24)
--)
--GO
--CREATE TABLE StudentsExams
--(
--StudentID INT,
--ExamID INT,
--FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
--FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
--)
--GO

--SET IDENTITY_INSERT Exams  ON
--GO

--INSERT INTO Students ([Name]) VALUES
--('Mila') ,                                    
--('Toni'),
--('Ron')

--INSERT INTO Exams (ExamID,[Name]) VALUES
--(101,	'SpringMVC'  ),
--(102,	'Neo4j'	   ),
--(103,	'Oracle 11g' )


--Problem 4.	Self-Referencing 

--CREATE TABLE Teachers
--(
--  TeacherID INT,
--  [Name] VARCHAR(30),
--  ManagerID INT
--)

--INSERT INTO TEACHERS(TeacherID,[Name],ManagerID)
--VALUES
--(101,	'John'	,NULL  ),
--(102	,'Maya'	,106	  ),
--(103	,'Silvia'	,106	  ),
--(104	,'Ted'	,105		  ),
--(105	,'Mark'	,101	  ),
--(106	,'Greta'	,101	  )


--Problem 5.	Online Store Database
--CREATE TABLE ORDERS
--(
-- OrderID INT,
-- CustomerID INT
--)
--GO
--CREATE TABLE Customers
--(
-- CustomerID INT,
-- [Name] VARCHAR(30),
-- Birthdate DATE,
-- CityID INT
--)
--GO
--CREATE TABLE Cities
--(
-- CityID INT,
-- [Name] VARCHAR(40)
--)
--GO
--CREATE TABLE Orderitems
--(
-- OrderID INT,
-- ItemID INT
--)
--GO
--CREATE TABLE Items
--(
-- ItemID INT,
-- [Name] VARCHAR(40),
-- ItemTypeID INT
--)
--GO
--CREATE TABLE ItemsTypes
--(
-- ItemTypeID INT,
-- [Name] VARCHAR(40)
--)

--Problem 6.	University Database
--