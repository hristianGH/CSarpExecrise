using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class ProductListViewModel
    {
        public ICollection<ProductOutputViewModel> Products { get; set; } = new List<ProductOutputViewModel>();
        public int Page { get; set; }
    }
}
