
namespace SiteX.Data.Models.Shop
{
    using SiteX.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Product : BaseDeletableModel<Guid>

    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(400)]
        [MinLength(3)]
        public string Description { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }


        public string Gender { get; set; }

        public bool IsAvalable { get; set; } = true;

        [MaxLength(4)]
        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        
        public ICollection<Location>  Locations { get; set; } = new List<Location>();
        
        public ICollection<Category> Categories { get; set; } = new List<Category>();

    }
}