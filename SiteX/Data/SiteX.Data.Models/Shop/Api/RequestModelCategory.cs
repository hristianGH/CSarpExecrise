using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Data.Models.Shop.Api
{
    public class RequestModelCategory
    {
        [Required, MaxLength(100), MinLength(3)]
        public string Name { get; set; }
    }
}
