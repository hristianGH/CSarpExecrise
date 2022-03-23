--Part I – Queries for SoftUni Database
 --FROM SoftUni.DBO.

--Problem 1.	Find Names of All Employees by First Name
--SELECT FirstName,LastName
--FROM Employees
--WHERE FirstName LIKE 'sa%' 
--GO

--Problem 2.	  Find Names of All employees by Last Name 
--SELECT FirstName,LastName
--FROM Employees
--WHERE LastName LIKE '%EI%'
--GO

--Problem 3.	Find First Names of All Employees
--SELECT FirstName
--FROM Employees
--WHERE DepartmentID IN (3,10)

--Problem 4.	Find All Employees Except Engineers
--SELECT *
--FROM Employees
--WHERE JobTitle NOT LIKE 'engineer%'

--Problem 5.	Find Towns with Name Length
--SELECT*
--FROM Towns
--WHERE LEN([Name]) BETWEEN 5 AND 6
--ORDER BY [Name]

--Problem 6.	 Find Towns Starting With
--SELECT * 
--FROM Towns
--WHERE SUBSTRING([Name],1,1) IN  ('M','K','B','E')
--ORDER BY [NAME]

--Problem 7.	 Find Towns Not Starting With
--SELECT*
--FROM Towns
--WHERE LEFT([NAME],1) NOT IN ('R','B','D')
--ORDER BY [NAME]

--Problem 8.	Create View Employees Hired After 2000 Year
--CREATE VIEW [V_EmployeesHiredAfter2000] AS
--SELECT FirstName,LastName
--FROM Employees
--WHERE HireDate >'2001'

--Problem 9.	Length of Last Name
--SELECT*
--FROM Employees
--WHERE LEN(LastName)=5

--Problem 10.	Rank Employees by Salary
--SELECT EmployeeID,FirstName,LastName,Salary,DENSE_RANK()OVER (ORDER BY SALARY  DESC)AS RANK
--FROM Employees
--WHERE SALARY BETWEEN 10000 AND 50000
 
 --Problem 11.	Find All Employees with Rank 2 *
-- SELECT *
--FROM 
--(SELECT EmployeeID,FirstName,LastName,Salary,DENSE_RANK()OVER (PARTITION BY SALARY ORDER BY EMPLOYEEID)AS [RANK]
--FROM Employees
--WHERE (Salary BETWEEN 10000 AND 50000)
--) A
--WHERE ([RANK] = 2)
--ORDER BY Salary DESC

--Part II – Queries for Geography Database 
--FROM Geography.DBO

--Problem 12.	Countries Holding ‘A’ 3 or More Times
--SELECT *
--FROM Countries
--WHERE LEN(CountryName) - LEN(REPLACE(CountryName,'A',''))>2
--ORDER BY IsoCode

--Problem 13.	 Mix of Peak and River Names
--SELECT  PeakName,RiverName,LOWER(CONCAT(PeakName,RiverName)) AS Mix
--FROM Peaks
-- JOIN Rivers
--ON RIGHT(PeakName,1) = LEFT(RiverName,1)
--ORDER BY Mix

-- Part III – Queries for Diablo Database
--FROM Diablo.dbo

--Problem 14.	Games from 2011 and 2012 year
--SELECT* INTO TEMPTABLE
--FROM Games
--GO
--ALTER TABLE TEMPTABLE
--ALTER COLUMN [START] DATE
--GO
--SELECT*
--FROM TEMPTABLE
--WHERE [START] BETWEEN '2011' AND '2012'
--ORDER BY [START]

--Problem 15.	 User Email Providers
--SELECT * ,SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email)) AS email_Povider
--FROM Users