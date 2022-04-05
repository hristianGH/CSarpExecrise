using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class ProductAllViewModel:PagingViewModel
    {
        public ICollection<ProductOutputViewModel> Products { get; set; } = new List<ProductOutputViewModel>();
       

    }
}
