using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Data.Models
{
    class Product
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
        public User Seller { get; set; }
        public int? BuyerId { get; set; }
        public User Buyer { get; set; }
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
        

    }
}
