using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    class PlayerStatistic
    {
         
        public virtual Game Game { get; set; }
        [Key]
        public int GameId { get; set; }
        public virtual Player Player { get; set; }
        [Key]
        public int PlayerId { get; set; }
        public int ScoredGoals { get; set; }
        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }
    }
}
//GameId, PlayerId, ScoredGoals, Assists, MinutesPlayed