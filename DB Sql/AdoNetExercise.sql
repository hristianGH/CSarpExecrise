--SELECT V.Name,COUNT(M.Id) AS NM
--FROM MinionsVillains MV
--JOIN Minions M
--ON M.Id=MV.MinionId
--JOIN Villains V
--ON V.Id=MV.VillainId
--GROUP BY V.Id,V.Name
--ORDER BY NM DESC


--DECLARE @ID INT;
--SET @ID=1;

--SELECT V.Name,M.Name,M.Age
--FROM Villains V
--JOIN MinionsVillains MV
--ON MV.VillainId=V.Id
--JOIN Minions M
--ON MV.MinionId= M.Id
--WHERE V.Id=@ID

--DECLARE @VillianName VARCHAR(30)
--SET @VillianName='GRU'
--SELECT V.Name,M.Name
-- FROM Villains V
-- JOIN MinionsVillains MV
-- ON MV.VillainId=V.Id
-- JOIN Minions M
-- ON MV.MinionId= M.Id
-- WHERE V.Name=@VillianName


--DECLARE @NAME VARCHAR(30)
--SET @NAME = '';
-- SELECT Name	
-- FROM Towns