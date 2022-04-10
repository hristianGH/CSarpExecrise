using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    public class BuyingProductViewModel:ToSelectList
    {
        public ProductOutputViewModel Product { get; set; }
        public Guid ProductId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
