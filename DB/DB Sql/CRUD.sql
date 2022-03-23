-- PART1.SOFTUNI DATABASE
------SELECT*
------FROM Departments;

------SELECT [NAME]
------FROM Departments

------SELECT FirstName,LastName,Salary
------FROM Employees
------ORDER BY Salary DESC

------SELECT CONCAT (FirstName,' ',MiddleName,' ',LastName) AS FULLNAME
------FROM Employees

------ SELECT CONCAT(FirstName+'.',LastName,'@softuni.bg') as [Full Email Address]
------ FROM Employees

------SELECT DISTINCT Salary
------FROM Employees
------ORDER BY Salary ASC 

------SELECT *
------FROM Employees
------WHERE JOBTITLE = 'Sales Representative'

------SELECT FIRSTNAME,LASTNAME,JOBTITLE
------FROM Employees
------WHERE Salary>20000 AND Salary< 30000

------SELECT CONCAT(FirstName+' ',MiddleName+' ',LastName) AS FULLNAME
------FROM Employees
------WHERE Salary =25000 OR Salary =14000 OR Salary =12500 or Salary=23600
----SELECT *
----FROM Employees
----WHERE ManagerID IS NULL

----SELECT FirstName,LastName,Salary
----FROM Employees
----WHERE Salary>50000
----ORDER BY Salary DESC
----GO

--SELECT TOP 5 FirstName,LastName
--FROM Employees
--ORDER BY Salary DESC
--GO

--SELECT FirstName,LastName 
--FROM Employees
--WHERE JobTitle!='MARKETING'

-- SELECT *
--FROM Employees
--ORDER BY Salary DESC,FirstName DESC,LastName DESC,MiddleName DESC

--CREATE VIEW EmployeesSalaries AS
--SELECT FirstName,LastName,Salary
--FROM Employees

--CREATE VIEW V_EmployeeNameJobTitle
--AS 
--SELECT CONCAT(FirstName+' ',ISNULL(MiddleName,' '),' ',LastName) AS FULLNAME
--FROM Employees

 --ALTER VIEW V_EmployeeNameJobTitle
 --AS SELECT CONCAT(FirstName+' ',ISNULL(MiddleName,' '),' ',LastName) AS FULLNAME ,JobTitle
 --FROM Employees

--SELECT*
--FROM V_EmployeeNameJobTitle

--SELECT DISTINCT JOBTITLE
--FROM Employees

--SELECT TOP 10 ProjectID AS ID,Name,Description,StartDate,EndDate
--FROM Projects
--ORDER BY StartDate ASC

--SELECT TOP 7 FirstName,LastName,HireDate
--FROM Employees
--ORDER BY HireDate DESC

--SELECT *
--INTO SALARY_INC 
--FROM Employees

--UPDATE SALARY_INC
--SET Salary=Salary*1.12
--WHERE DepartmentID IN (1,2,4,11)

----PART2.GEO DATABASE USING GEOGRAPHY.DBO

--SELECT*
--FROM Peaks

--SELECT* CountryName,Population
--FROM Countries
--WHERE ContinentCode ='EU'
--ORDER BY Population DESC

--SELECT CountryName,CountryCode,CurrencyCode,'' AS CURRENCY
--INTO IsCurrency_EURO
--FROM Countries
 
 --SELECT *, CASE WHEN CurrencyCode='EUR'THEN 'Euro'ELSE'Not Euro' END AS CURRENCY2 
 --FROM IsCurrency_EURO
 

--UPDATE  IsCurrency_EURO
--SET CURRENCY = (CASE WHEN(CurrencyCode='EUR') THEN  'Euro' ELSE( 'NotEuro' )END)
--GO
--SELECT* 
--FROM IsCurrency_EURO

--PART 3 DIABLO
--USING Diablo.DBO

--SELECT*
--FROM  Characters
--ORDER BY NAME ASC