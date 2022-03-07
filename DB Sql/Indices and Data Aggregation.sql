--FROM Gringotts

--1. Records’ Count

--SELECT COUNT(*) [COUNT]
--FROM WizzardDeposits

--2. Longest Magic Wand
--SELECT TOP 1 MagicWandSize [LongestMagicWand]
--FROM WizzardDeposits
--ORDER BY MagicWandSize DESC

--3. Longest Magic Wand Per Deposit Groups
--SELECT DepositGroup,MAX(MagicWandSize)
--FROM WizzardDeposits
--GROUP BY DepositGroup

--4. * Smallest Deposit Group Per Magic Wand Size
--SELECT DepositGroup,MIN(MagicWandSize)
--FROM WizzardDeposits
--GROUP BY DepositGroup

--5. Deposits Sum
--SELECT DepositGroup,SUM(DepositAmount)
--FROM WizzardDeposits
--GROUP BY DepositGroup

--6. Deposits Sum for Ollivander Family
--SELECT DepositGroup,SUM(DepositAmount)
--FROM WizzardDeposits
--WHERE MagicWandCreator ='Ollivander family'
--GROUP BY DepositGroup

--7. Deposits Filter
--SELECT DepositGroup,SUM(DepositAmount)AS TOTAL
--FROM WizzardDeposits
--WHERE MagicWandCreator ='Ollivander family'
--GROUP BY DepositGroup
-- HAVING SUM(DepositAmount) < 150000
-- ORDER BY TOTAL DESC

--8.  Deposit Charge
--SELECT DepositGroup,MagicWandCreator,MIN(DepositCharge)
--FROM WizzardDeposits
--GROUP BY DepositGroup,MagicWandCreator
--ORDER BY   DepositGroup,MagicWandCreator

--9. Age Groups
--SELECT AG.AGEGROUP,COUNT(AG.AGEGROUP) FROM
--(
--SELECT CASE
--WHEN AGE <=10 THEN '[0-10]'
--WHEN AGE BETWEEN 11 AND 20 THEN '[11-20]'
--WHEN AGE BETWEEN 21 AND 30 THEN '[21-30]'
--WHEN AGE BETWEEN 31 AND 40THEN '[31-40]'
--WHEN AGE BETWEEN 41 AND 50 THEN '[41-50]'
--WHEN AGE BETWEEN 51 AND 60 THEN '[51-60]'
--ELSE '[61+]' END AS AGEGROUP
--FROM WizzardDeposits
--)AS AG
--GROUP BY AGEGROUP

--10. First Letter
--SELECT LEFT(FirstName,1) LF
--FROM WizzardDeposits
-- WHERE DepositGroup ='Troll Chest'
-- GROUP BY LEFT(FirstName,1)

--11. Average Interest 
 --SELECT DepositGroup ,IsDepositExpired,AVG(DepositInterest)AS AverageInterest
 --FROM WizzardDeposits
 --WHERE DepositStartDate  >'01/01/1985'
 --GROUP BY DepositGroup,IsDepositExpired
 --ORDER BY DepositGroup DESC, IsDepositExpired ASC

 --12. * Rich Wizard, Poor Wizard
 --SELECT SUM(Y.DIF) FROM(
 --SELECT H.FirstName AS HostWizard,H.DepositAmount,G.FirstName AS GuestWizard,(H.DepositAmount-G.DepositAmount) AS DIF
 --FROM WizzardDeposits H
 --JOIN  WizzardDeposits G
 --ON G.Id = H.Id+1)AS Y

 --FROM SOFTUNI

 --13. Departments Total Salaries
 --SELECT DEPARTMENTID, SUM(Salary)
 --FROM Employees
 --GROUP BY DepartmentID

 --14. Employees Minimum Salaries
 --SELECT DepartmentID,MIN(Salary)
 --FROM Employees
 --WHERE DepartmentID IN (2,5,7) AND HireDate >'01/01/2000'
 --GROUP BY DepartmentID

 --15. Employees Average Salaries
 -- SELECT DepartmentID,AVG(O.NewS) FROM (
 --SELECT DepartmentID,CASE 
 --WHEN DepartmentID =1 THEN SALARY +5000
 --ELSE SALARY +0  END AS [NewS]
 --FROM Employees
 --WHERE Salary>30000 AND ManagerID !=42 
 --)AS O
 --GROUP BY DepartmentID

 --16. Employees Maximum Salaries
 --SELECT DepartmentID,MAX(Salary)
 --FROM Employees
 --WHERE SALARY NOT BETWEEN 30000 AND 70000
 --GROUP BY DepartmentID

 --17. Employees Count Salaries
 --SELECT COUNT(EmployeeID)
 --FROM Employees
 --WHERE ManagerID IS NULL

 --18. *3rd Highest Salary
 --SELECT G.DepartmentID,G.Salary FROM(
 --SELECT DepartmentID,Salary,DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY SALARY ) AS RANKED
 --FROM Employees
 --GROUP BY DepartmentID,Salary
 --)G
 --WHERE G.RANKED = 2