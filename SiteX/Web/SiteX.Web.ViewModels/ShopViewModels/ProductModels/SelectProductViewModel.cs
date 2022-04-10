using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    public class SelectProductViewModel
    {
        [Required]
        public Guid ProductId { get; set; }


    }
}
