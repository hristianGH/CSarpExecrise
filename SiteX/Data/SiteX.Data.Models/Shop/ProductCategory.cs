using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiteX.Data.Models.Shop
{
    public class ProductCategory 
    {
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
