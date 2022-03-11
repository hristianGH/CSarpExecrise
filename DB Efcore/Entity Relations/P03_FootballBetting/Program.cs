using System;
using P03_FootballBetting.Data.Models;
using P03_FootballBetting.Data;

namespace P03_FootballBetting
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new FootballBettingContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }
    }
}
