using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Data.Models
{
    class User
    {

        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        [MinLength(3)]
        public string LastName { get; set; }
        public int? Age { get; set; }
        public ICollection<Product> ProductsSold { get; set; }
        public ICollection<Product> ProductsBought { get; set; }

    }
}
