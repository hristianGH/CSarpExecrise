using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class ProductOutputViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Category> Categories{ get; set; }

        public decimal Price { get; set; }

        public ICollection<Location> Locations { get; set; }
        public string Description { get; set; }


    }
}
