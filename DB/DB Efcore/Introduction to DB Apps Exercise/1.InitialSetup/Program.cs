using System;
using System.Data.SqlClient;
using System.Linq;

namespace _1.InitialSetup
{
    class Program
    {
        const string sqlAddress = "Server=.;Database=MinionsDB;Integrated Security=true;";

        static void Main(string[] args)
        {

            using (var connection = new SqlConnection(sqlAddress))
            {
                connection.Open();
       
                
            }


        }
        static void AddMinion(SqlConnection connection)
        {
            bool vilExist = false, minExist = false;
            string[] minionInfo = Console.ReadLine().Split();
            string vilianName = Console.ReadLine().Split()[1];

            string query = $@"DECLARE @VillianName VARCHAR(30)
                                SET @VillianName = '{vilianName}'
                                SELECT V.Name,M.Name
                                FROM Villains V
                                JOIN MinionsVillains MV
                                ON MV.VillainId = V.Id
                                JOIN Minions M
                                ON MV.MinionId = M.Id
                                WHERE V.Name = @VillianName";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(Convert.ToString($"{reader[0]} {reader[1]}"));
                        vilExist = true;
                        if (reader[1] == minionInfo[1])
                        {
                            minExist = true;
                        }
                    }
                }
            }
            TownCheck(connection, minionInfo[3]);
            if (vilExist == false)
            {

                Console.WriteLine($"Villain {vilianName} was added to the database.");
            }

            Console.WriteLine(minExist ? "true" : $"Successfully added {minionInfo[1]} to be minion of {vilianName}.");
        }
        static void TownCheck(SqlConnection connection, string townName)
        {
            bool isTownFound = false;
            string query = $@"DECLARE @NAME VARCHAR(30)
           SET @NAME = '{townName}';
            SELECT Name
            FROM Towns";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0] == townName)
                        {
                            isTownFound = true;
                        }
                    }
                }
            }
            if (isTownFound == false)
            {
                Console.WriteLine($"Town {townName} was added to the database.");
            }
        }

        static void MinionNames(SqlConnection connection)
        {
            int id = int.Parse(Console.ReadLine());
            string query = $@"
                    DECLARE @ID INT;
                SET @ID = {id};

                SELECT V.Name,M.Name,M.Age
                FROM Villains V
                JOIN MinionsVillains MV
                ON MV.VillainId = V.Id
                JOIN Minions M
                ON MV.MinionId = M.Id
                WHERE V.Id = @ID";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    id = 1;
                    if (reader.Read())
                    {

                        Console.WriteLine($"Villain: {reader[0]}");
                        Console.WriteLine($"{id}. {reader[1]} {reader[2]}");
                        id++;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine($"{id}. {reader[1]} {reader[2]}");
                        id++;
                    }

                }
            }
        }
        static void MinionCount(SqlConnection connection)
        {
            string commandTxt = @"SELECT V.Name,COUNT(M.Id) AS NM 
                FROM MinionsVillains MV 
                   JOIN Minions M ON M.Id = MV.MinionId 
                         JOIN Villains V ON V.Id = MV.VillainId 
                           GROUP BY V.Id,V.Name ORDER BY NM DESC";

            using (var command = new SqlCommand(commandTxt, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }
                }
            }
        }
        static void InitialSetup(SqlConnection conn)
        {

            foreach (var command in CommandsCreateTable())
            {

                using (var execCommand = new SqlCommand(command, conn))
                {
                    execCommand.ExecuteNonQuery();
                }
            }
            foreach (var command in CommandsInsertData())
            {
                using (var execCommand = new SqlCommand(command, conn))
                {
                    execCommand.ExecuteNonQuery();
                }
            }
            var createTable = conn.CreateCommand();

        }
        static string[] CommandsCreateTable()
        {
            string[] co =
                { "CREATE TABLE Countries(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))",
                "CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50), CountryCode INT FOREIGN KEY REFERENCES Countries(Id))",
                "CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(30), Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id))",
                "CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))",
                "CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))",
                "CREATE TABLE MinionsVillains (MinionId INT FOREIGN KEY REFERENCES Minions(Id),VillainId INT FOREIGN KEY REFERENCES Villains(Id),CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))" };
            return co;
        }
        static string[] CommandsInsertData()

        {
            string[] co =
            {
                    "INSERT INTO Countries ([Name]) VALUES('Bulgaria'),('England'),('Cyprus'),('Germany'),('Norway')",
                    "INSERT INTO Towns ([Name], CountryCode) VALUES('Plovdiv', 1),('Varna', 1),('Burgas', 1),('Sofia', 1),('London', 2),('Southampton', 2),('Bath', 2),('Liverpool', 2),('Berlin', 3),('Frankfurt', 3),('Oslo', 4)",
                    "INSERT INTO Minions (Name, Age, TownId) VALUES('Bob', 42, 3),('Kevin', 1, 1),('Bob ', 32, 6),('Simon', 45, 3),('Cathleen', 11, 2),('Carry ', 50, 10),('Becky', 125, 5),('Mars', 21, 1),('Misho', 5, 10),('Zoe', 125, 5),('Json', 21, 1)",
                    "INSERT INTO EvilnessFactors (Name) VALUES('Super good'),('Good'),('Bad'), ('Evil'),('Super evil')",
                    "INSERT INTO Villains (Name, EvilnessFactorId) VALUES('Gru', 2),('Victor', 1),('Jilly', 3),('Miro', 4),('Rosen', 5),('Dimityr', 1),('Dobromir', 2)",
                    "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES(4, 2),(1, 1),(5, 7),(3, 5),(2, 6),(11, 5),(8, 4),(9, 7),(7, 1),(1, 3),(7, 3),(5, 3),(4, 3),(1, 2),(2, 1),(2, 7)"
                };

            return co;
        }
    }
}






