using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class IndexViewModel
    {
        public ICollection<Category> Categories { get; set; }=new List<Category>();
        public ICollection<Location> Locations { get; set; }=new List<Location>();
        public ICollection<Product> Products { get; set; }= new List<Product>();

    }
}
