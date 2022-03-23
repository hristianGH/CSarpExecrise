using System;
using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    class Game
    {
        //public Game()
        //{
        //    DateTime = new DateTime();
        //}
        public int GameId { get; set; }
        public virtual Team HomeTeam { get; set; }
        public int HomeTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
       // public Bet Bet { get; set; }
        public double HomeTeamBetRate { get; set; }
        public double AwayTeamBetRate { get; set; }
        public decimal PredictionResult { get; set; }
        public double DrawBetRate { get; set; }
        public string Result { get; set; }
       // public ICollection<Player> Players { get; set; }
        public ICollection<Bet> Bets { get; set; }
    }
}
//GameId, HomeTeamId, AwayTeamId, HomeTeamGoals, AwayTeamGoals, DateTime, HomeTeamBetRate, AwayTeamBetRate, DrawBetRate, Result)