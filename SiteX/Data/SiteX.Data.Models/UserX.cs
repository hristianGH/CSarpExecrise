using Microsoft.AspNetCore.Identity;
using SiteX.Data.Models.Blog;
using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models
{
    public class UserX
    {

        [Required, MaxLength(100)]
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Product> Products { get; set; }=new List<Product>();
         
         
    }
}
