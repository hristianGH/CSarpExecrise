using SiteX.Data.Models.Shop;
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
        public ICollection<ProductOutputViewModel> ToList(int page = 1, int itemsPerPage = 6);
        public Task RemoveProductAsync(Product product);
        public Task RemoveALLAsync();
        public ICollection<Product> ReturnAll();
        public Task CreatingProductCategory(ProductViewModel viewModel, Product product);

        public Task CreatingProductLocation(ProductViewModel viewModel, Product product);
        public int GetProductCount();
        public Product GetProductById(Guid id);
        public Task EditAsync(ProductEditViewModel viewModel);


    }
}
