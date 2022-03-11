using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
     class Country
    {
        [Key]
        public int CoutryId { get; set; }
        public string Name { get; set; }
        public ICollection<Town> Towns { get; set; }
    }
}