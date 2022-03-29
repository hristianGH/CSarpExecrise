using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Shop
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
    }
}
