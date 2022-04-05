
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
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();

        //TODO LOCATION SHOW PRODUCT ID IN SQL 
        public ICollection<ProductLocation> ProductLocations { get; set; } = new List<ProductLocation>();


    }
}