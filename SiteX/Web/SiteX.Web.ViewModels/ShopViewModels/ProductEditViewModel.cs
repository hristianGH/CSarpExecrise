using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class ProductEditViewModel
    {
        public Product OldProduct { get; set; }

        public Guid OldProductId { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }
        public string Gender { get; set; }

        
        public virtual ICollection<ProductImage> Pictures { get; set; } = new List<ProductImage>();

        public ICollection<ProductCategory> Locations { get; set; } = new List<ProductCategory>();

        //TODO LOCATION SHOW PRODUCT ID IN SQL 
        public ICollection<ProductLocation> Categories { get; set; } = new List<ProductLocation>();

    }
}
