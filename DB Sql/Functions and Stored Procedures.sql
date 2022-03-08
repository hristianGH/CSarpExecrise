--	Queries for SoftUni Database

--1.	Employees with Salary Above 35000
--CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
--AS
--SELECT FirstName,LastName
--FROM Employees
--WHERE Salary>35000
--GO
--EXECUTE usp_GetEmployeesSalaryAbove35000
--GO

--2.	Employees with Salary Above Number
--CREATE OR ALTER PROCEDURE usp_GetEmployeesSalaryAboveNumber @SalNum DECIMAL
--AS 
--SELECT FirstName,LastName
--FROM Employees
--WHERE Salary>=@SalNum
--GO
--EXECUTE usp_GetEmployeesSalaryAboveNumber 48100

--3.	Town Names Starting With
--CREATE OR ALTER PROCEDURE usp_GetTownsStartingWith  @Param VARCHAR(30)
--AS
--SELECT @Param = @Param+'%'
--SELECT * 
--FROM Towns T
--WHERE T.Name LIKE @Param
--GO
--EXECUTE usp_GetTownsStartingWith 'B'

--4.	Employees from Town
--CREATE OR ALTER PROCEDURE usp_GetEmployeesFromTown   @Param VARCHAR(15) AS
--SELECT E.FirstName,E.LastName,T.Name
--FROM Employees E
--JOIN Addresses A ON A.AddressID=E.AddressID 
-- JOIN Towns T ON T.TownID=A.TownID
-- WHERE T.Name LIKE @Param+'%'
-- GO
-- EXEC usp_GetEmployeesFromTown SOFIA

--5.	Salary Level Function
--CREATE OR ALTER FUNCTION ufn_GetSalaryLevel (@SalaryP DECIMAL)
--RETURNS VARCHAR(16) AS
--BEGIN
--DECLARE @LVL VARCHAR(16);
-- IF(@SalaryP<15000)
-- SET @LVL ='Low'
-- ELSE IF (@SalaryP>50000)
-- SET @LVL ='High'
-- ELSE SET @LVL='Average'
-- RETURN @LVL
--END
--GO
--SELECT Salary, DBO.ufn_GetSalaryLevel(Salary)
--FROM Employees

--6.	Employees by Salary Level
--CREATE OR ALTER PROCEDURE usp_EmployeesBySalaryLevel @LVL VARCHAR(16)
--AS
--SELECT FirstName,LastName
--FROM Employees
--WHERE DBO.ufn_GetSalaryLevel(Salary) = @LVL
--GO
--EXEC usp_EmployeesBySalaryLevel [HIGH]

--7.	Define Function
--CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(30), @word VARCHAR(30))
--RETURNS BIT 
--AS BEGIN
--DECLARE @IsIt BIT,@I INT,@J INT;
--SET @I= 1;
--SET @J=1;

--WHILE(@I<=LEN(@word)) 
--	BEGIN
--		DECLARE @CH VARCHAR;
--		SET @CH= SUBSTRING(@word,@I,1)
--			WHILE(@J<=LEN(@setOfLetters))
--				BEGIN

--					IF (@CH =SUBSTRING(@setOfLetters,@J,1) )
--					BEGIN
--						SET @IsIt=1;
--						SET @J=@J+1;
--						BREAK
--						END

--					ELSE 
--					BEGIN
--						SET @IsIt=0;
--						SET @J=@J+1;
--					END

--				END

--		IF(@IsIt = 0)
--		BREAK;

--		ELSE 
--		BEGIN
--		SET @I=@I+1
--		SET @J=1
--		END

--	END
--	RETURN @ISIT
--END
-- GO

--	Queries for Bank Database

--9.	Find Full Name
--CREATE OR ALTER PROCEDURE usp_GetHoldersFullName AS
--SELECT CONCAT_WS (' ',FirstName, LastName) AS FullName
--FROM Accounts A
--JOIN AccountHolders AH
--ON AH.Id = A.AccountHolderId

--10.	People with Balance Higher Than
--CREATE OR ALTER PROCEDURE usp_GetHoldersWithBalanceHigherThan (@Amount DECIMAL)
--AS
--SELECT FirstName,LastName 
--FROM Accounts A
--JOIN AccountHolders AH
--ON AH.Id=A.AccountHolderId
--WHERE A.Balance>@Amount
--ORDER BY FirstName,LastName
--GO
--EXEC usp_GetHoldersWithBalanceHigherThan 50000


--11.	Future Value Function
--CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@InitialSum DECIMAL,@YearlyInterest FLOAT,@NumOfYears INT) 
--	RETURNS DECIMAL(16,4)
--		AS
--		BEGIN
--			DECLARE @OUT DECIMAL(16,4)
--			SET @YearlyInterest = CONVERT(real,@YearlyInterest)
--			SET @OUT=@InitialSum*(POWER((1.0+@YearlyInterest),@NumOfYears));
--			RETURN @OUT
--END
--GO
--SELECT DBO.ufn_CalculateFutureValue(1000,0.1,5) 
 
 --12.	Calculating Interest
--CREATE OR ALTER PROCEDURE usp_CalculateFutureValueForAccount AS
--	SELECT A.Id, FirstName,LastName,Balance,DBO.ufn_CalculateFutureValue(Balance,0.1,5) AS [In5Years]
--		FROM Accounts A
--			JOIN AccountHolders AH
--		ON AH.ID=A.AccountHolderId

--EXECUTE usp_CalculateFutureValueForAccount