using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    public class ProductAllViewModel:PagingViewModel
    {
        public ICollection<ProductOutputViewModel> Products { get; set; } = new List<ProductOutputViewModel>();
       

    }
}
