using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Blog
{
    public class PostImage
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Path { get; set; }
    }
}
