using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Data.Models.Shop
{
    public class ProductSize: BaseDeletableModel<int>
    {
        public Size Size { get; set; }
        public int SizeId { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
