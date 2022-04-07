using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Data.Models.Shop
{
    public class ProductLocation 
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
