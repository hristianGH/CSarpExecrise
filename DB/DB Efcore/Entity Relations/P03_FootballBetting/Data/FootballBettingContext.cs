﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using P03_FootballBetting.Data.Models;



namespace P03_FootballBetting.Data
{
    class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }
        public FootballBettingContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =.;Database= FootballBetting;Integrated Security = true");

            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>().HasKey(x => new { x.GameId, x.PlayerId });
            modelBuilder.Entity<Team>().HasOne(x => x.PrimaryKit).WithMany(x => x.PrimaryKitTeams)
            .HasForeignKey(x => x.PrimaryColorId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>().HasOne(x => x.SecondaryKit).WithMany(x => x.SecondaryKitTeams)
             .HasForeignKey(x => x.SecondaryColorId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>().HasOne(x => x.HomeTeam).WithMany(x => x.HomeGames).HasForeignKey(x => x.HomeTeamId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Game>().HasOne(x => x.AwayTeam).WithMany(x => x.AwayGames).HasForeignKey(x => x.AwayTeamId).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
