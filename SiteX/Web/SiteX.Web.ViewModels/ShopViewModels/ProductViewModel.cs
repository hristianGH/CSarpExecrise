﻿using SiteX.Data.Models;
using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class ProductViewModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        [Display(Name = "Name of product")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Price in Bgn")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(400)]
        [MinLength(3)]
        public string Description { get; set; }
        public ApplicationUser User { get; set; }

        public string Gender { get; set; }

        [MaxLength(4)]
        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

        [MaxLength(4)]

        public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

        [MinLength(1),MaxLength(4)]
        public virtual ICollection<int> Categories { get; set; } = new List<int>();

    }
}
