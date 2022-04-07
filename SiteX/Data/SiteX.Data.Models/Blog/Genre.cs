using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Data.Models.Blog
{
    public class Genre :BaseModel<int>
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
