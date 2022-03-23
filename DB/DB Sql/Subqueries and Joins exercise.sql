--FROM SoftUni.dbo

--1.	Employee Address

--SELECT TOP 5 EmployeeID,CONCAT_WS(' ',FIRSTNAME,MiddleName,LASTNAME) ,JobTitle,A.AddressID,A.AddressText
--FROM Employees AS E JOIN Addresses AS A
--ON A.ADDRESSID=E.ADDRESSID
--ORDER BY A.AddressID

--2.	Addresses with Towns
--SELECT FirstName,LastName,A.AddressID,T.[Name]
--FROM Employees AS E
--JOIN Addresses AS A
--ON A.AddressID=E.AddressID
--JOIN Towns AS T
--ON T.TownID=A.TownID
--ORDER BY FirstName ,LastName

--3.	Sales Employee
--SELECT E.EmployeeID,CONCAT_WS(' ',FirstName,MiddleName,LastName) AS [NAME],D.DepartmentID,D.[Name]
--FROM Employees AS E,Departments AS D
--WHERE D.DepartmentID=E.DepartmentID AND D.Name='SALES'
--ORDER BY E.DepartmentID

--4.	Employee Departments
--SELECT E.EmployeeID,E.FirstName,E.Salary,D.[Name]
--FROM Employees E ,
--Departments D
--WHERE D.DepartmentID=E.DepartmentID AND E.Salary>14999

--5.	Employees Without Project
--SELECT E.EmployeeID , FirstName
--FROM EmployeesProjects EP RIGHT JOIN Employees E
--ON E.EmployeeID=EP.EmployeeID
--WHERE EP.EmployeeID IS NULL
--ORDER BY E.EmployeeID

--6.	Employees Hired After
--SELECT FirstName,LastName,HireDate,D.Name [DepName]
--FROM Employees E,Departments D
--WHERE D.DepartmentID=E.DepartmentID AND E.HireDate>'1.1.1999' AND D.[Name] IN ('SALES','FINANCE')

--7.	Employees with Project

--SELECT E.EmployeeID,E.FirstName,P.[Name][ProjectName],EndDate
--FROM Employees E JOIN EmployeesProjects EP 
--ON EP.EmployeeID=E.EmployeeID
--JOIN Projects P
--ON EP.ProjectID=P.ProjectID
--WHERE CONVERT(varchar,P.StartDate,104) >'13.08.2002' AND 
--EndDate IS NULL
--ORDER BY EmployeeID

--8.	Employee 24

--SELECT E.EmployeeID,FirstName,P.[Name][ProjectName],
--CASE WHEN P.StartDate >='2005' THEN NULL
--WHEN P.StartDate <'2005' THEN P.StartDate
--END AS [StartDate]
--FROM Employees E JOIN EmployeesProjects EP
--ON E.EmployeeID= EP.EmployeeID
--JOIN Projects P
--ON EP.ProjectID = P.ProjectID
--WHERE E.EmployeeID = 24  

--9.	Employee Manager

--SELECT E1.EmployeeID,E1.FirstName,E1.ManagerID,E2.FirstName
--FROM Employees E1  JOIN Employees E2
--ON E2.EmployeeID=E1.ManagerID
--WHERE E1.ManagerID IN (3,7)
--ORDER BY E1.EmployeeID

--10. Employee Summary
--SELECT E1.EmployeeID,CONCAT_WS(' ',E1.FirstName,E1.LastName) AS [EmployeeName],CONCAT_WS(' ',E2.FirstName,E2.LastName)AS [ManagerName],D.[Name] AS [DepartmentName]
--FROM Employees E1
--JOIN Departments D
--ON D.DepartmentID=E1.DepartmentID
--JOIN Employees E2
--ON E2.EmployeeID=E1.ManagerID


--11. Min Average Salary
--SELECT AVG(Salary)AS MinAverageSalary
--FROM Employees
--GROUP BY DepartmentID
--ORDER BY MinAverageSalary

--FROM Geography.DBO

--12. Highest Peaks in Bulgaria

--SELECT MC.CountryCode,M.MountainRange,P.PeakName,P.Elevation
--FROM Peaks P JOIN Mountains M
--ON M.Id=P.MountainId
--JOIN MountainsCountries MC
--ON MC.MountainId=M.Id
--WHERE P.Elevation>2835 AND MC.CountryCode='BG'
--ORDER BY Elevation DESC

--13. Count Mountain Ranges
 
--SELECT MC.CountryCode,COUNT(MC.CountryCode) 
--FROM Mountains M
--JOIN MountainsCountries MC
--ON M.Id=MC.MountainId
--WHERE MC.CountryCode IN ('RU','US','BG')
--GROUP BY MC.CountryCode

--14. Countries with Rivers

--SELECT C.CountryName,R.RiverName
--FROM Rivers R
--JOIN CountriesRivers CR
--ON CR.RiverId=R.Id
--JOIN Countries C
--ON C.CountryCode=CR.CountryCode
--WHERE C.ContinentCode='AF'
--ORDER BY C.CountryName

--15. *Continents and Currencies

--SELECT*
--FROM
--(
--SELECT CT.ContinentCode,CT.CurrencyCode,COUNT(CT.CurrencyCode) AS [CONT],DENSE_RANK()OVER(PARTITION BY CT.ContinentCode ORDER BY COUNT(CT.CurrencyCode)DESC) AS [RANK]
--FROM Countries CT
--GROUP BY CT.ContinentCode,CT.CurrencyCode
-- ) AS D
-- WHERE D.[RANK]=1 AND D.CONT>1
-- ORDER BY D.ContinentCode 

--16. Countries Without Any Mountains
--SELECT ABS((P.[WITH])-(P.[W OUT])) AS [COUNT]
--FROM(
--SELECT COUNT(DISTINCT MC.CountryCode) AS [WITH],COUNT(DISTINCT C.CountryCode) AS [W OUT]
--FROM MountainsCountries MC ,Countries C
--) P

--16. Highest Peak and Longest River by Country

--SELECT MAX(P.Elevation)AS ELE,MAX(R.Length) AS LE,C.CountryName
--FROM Countries C JOIN CountriesRivers CR
--ON CR.CountryCode=C.CountryCode
--JOIN Rivers R 
--ON CR.RiverId= R.Id 
--JOIN MountainsCountries MC
--ON MC.CountryCode=C.CountryCode
--JOIN Mountains M 
--ON M.Id=MC.MountainId
--JOIN Peaks P 
--ON P.MountainId = M.Id
--GROUP BY C.CountryName
-- ORDER BY ELE DESC,LE DESC  
 

--18. Highest Peak Name and Elevation by Country

--SELECT Country,[Highest Peak Name],[Highest Peak Elevation],Mountain,DR FROM
--(
--SELECT C.CountryName [Country],P.PeakName AS [Highest Peak Name]
--,P.Elevation AS [Highest Peak Elevation],M.MountainRange AS Mountain
--,DENSE_RANK()OVER(PARTITION BY C.COUNTRYNAME ORDER BY MAX(P.ELEVATION) DESC) AS DR
--FROM Countries C 
-- JOIN MountainsCountries MC 
--ON MC.CountryCode=C.CountryCode
-- JOIN Mountains M 
--ON M.Id = MC.MountainId 
-- JOIN Peaks P 
--ON P.MountainId = MC.MountainId
--GROUP BY  C.CountryName,P.PeakName,P.Elevation,M.MountainRange,C.CountryCode,P.ELEVATION
--) AS G
--UNION
--SELECT*
--FROM
--(
--SELECT C.CountryName AS[Country],'(no highest peak)' AS [Highest Peak Name],0 AS [Highest Peak Elevation],'(no moutain)'AS Mountain,0 AS DR
--FROM Countries C
--LEFT JOIN MountainsCountries MC 
--ON MC.CountryCode=C.CountryCode
--) AS G1
--ORDER BY Country,[Highest Peak Name] DESC

