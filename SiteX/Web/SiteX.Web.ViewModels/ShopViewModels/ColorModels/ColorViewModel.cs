using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels.ColorModels
{
    public class ColorViewModel
    {
        [Required, MaxLength(100), MinLength(3)]
        public string Name { get; set; }
    }
}
