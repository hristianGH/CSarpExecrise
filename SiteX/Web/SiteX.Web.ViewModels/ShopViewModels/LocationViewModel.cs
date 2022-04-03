using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class LocationViewModel
    {

        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }


        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Address { get; set; }

    }
}
