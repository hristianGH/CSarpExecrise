﻿using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
     class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}