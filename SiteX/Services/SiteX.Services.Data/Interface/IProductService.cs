using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.Interface
{
    public interface IProductService
    {
        public Task CreateAsync(ProductViewModel viewModel);
        public ICollection<ProductOutputViewModel> ToList(int page, int itemsPerPage = 6);

    }
}
