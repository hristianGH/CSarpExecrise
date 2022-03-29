using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Shop
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required, MaxLength(400), MinLength(3)]
        public string Description { get; set; }
        public bool IsAvalable { get; set; }
        [MaxLength(4)]
        public ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public ICollection<Location> Locations { get; set; } = new List<Location>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();

    }
}
