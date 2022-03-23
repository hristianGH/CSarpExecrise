using System;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Data;


namespace P01_StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentContext = new StudentSystemContext();
            studentContext.Database.EnsureDeleted();
            studentContext.Database.EnsureCreated();

        }
    }
}
//dotnet add package Microsoft.EntityFrameworkCore.Tools 
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design
