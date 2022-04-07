﻿namespace SiteX.Data.Models.Shop
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using SiteX.Data.Common.Models;

    public class ProductImage :BaseDeletableModel<int>
    {
     
        [Required]
        public string Path { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }

    }
}
