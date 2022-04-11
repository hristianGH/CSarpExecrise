using System.Collections.Generic;

namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    public class ProductAllViewModel : PagingViewModel
    {
        public ICollection<ProductOutputViewModel> Products { get; set; } = new List<ProductOutputViewModel>();

        public ToSelectList ToSelectList { get; set; }
    }
}
