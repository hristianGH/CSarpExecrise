using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.Models
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
