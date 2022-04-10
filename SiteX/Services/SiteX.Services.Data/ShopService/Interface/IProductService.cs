using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Models;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IProductService
    {
        public Task CreateAsync(ProductViewModel viewModel);

        public ICollection<ProductOutputViewModel> ToPage(int page = 1, int itemsPerPage = 6);

        public ICollection<ProductOutputViewModel> GetAllProductsAsOutModel();

        public ICollection<ProductOutputViewModel> SortedByCategoryId(int id);

        public Task RemoveProductAsync(Product product);

        public Task RemoveALLAsync();

        public Task SoftDeleteProductByIdAsync(Guid id);

        public ICollection<Product> ReturnAll();

        public int GetProductCount();

        public Product GetProductById(Guid id);
        public ProductOutputViewModel GetOutputProductById(Guid id);

        public Task EditAsync(ProductEditViewModel viewModel);

    }
}
