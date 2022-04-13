namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SiteX.Data.Models;
    using SiteX.Data.Models.Shop;

    public class ProductEdit : ToSelectList
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        [Display(Name = "Name of product")]
        public string Name { get; set; }

        [Required]
        [Range(1, double.MaxValue - 100)]
        [Display(Name = "Price in Bgn")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(400)]
        [MinLength(3)]
        public string Description { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [MinLength(1)]
        [Display(Name = "Picture Url")]
        public virtual ICollection<string> Pictures { get; set; } = new List<string>();

        [Required]
        [MaxLength(4)]

        public virtual ICollection<int> Locations { get; set; } = new List<int>();

        [MinLength(1)]
        [MaxLength(3)]
        public virtual ICollection<int> Categories { get; set; } = new List<int>();

        [MinLength(1)]
        public virtual ICollection<int> Sizes { get; set; } = new List<int>();

        [MinLength(1)]
        public virtual ICollection<int> Colors { get; set; } = new List<int>();
    }
}
