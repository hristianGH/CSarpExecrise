using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int SquadNumber { get; set; }
        public virtual Team Team { get; set; }
        public int TeamId { get; set; }
        public virtual Position Position { get; set; }
        public int PositionId { get; set; }
        public bool IsInjured { get; set; }
        //public ICollection<Bet> Bets { get; set; }
        public ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}
//– PlayerId, Name, SquadNumber, TeamId, PositionId, IsInjured