using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        [MaxLength(3)]
        public string Initials { get; set; }
        public decimal Buget { get; set; }
        public virtual Color PrimaryKit  { get; set; }
        public int PrimaryColorId { get; set; }
        public virtual Color SecondaryKit { get; set; }
        public int SecondaryColorId { get; set; }
        public virtual Town Town { get; set; }
        public int TownId { get; set; }
        public ICollection<Game> HomeGames { get; set; }
        public ICollection<Game> AwayGames { get; set; }
        public ICollection<Player> Players { get; set; }


    }

    //TeamId, Name, LogoUrl, Initials (JUV, LIV, ARS…), Budget, PrimaryKitColorId, SecondaryKitColorId, TownId
}