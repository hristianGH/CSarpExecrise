using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Data.Models.Shop
{
    public class ProductColor: BaseDeletableModel<int>
    {
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
