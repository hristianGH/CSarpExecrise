using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Blog
{
    public class Poster
    {
        [Key]
        public Guid Id { get; set; }

        [Required,MaxLength(100),MinLength(3)]
        public string Name { get; set; }

        [Required,MaxLength(100),MinLength(0)]
        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; }=new List<Post>();
    }
}
