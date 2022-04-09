using SiteX.Data.Models.Shop;
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

        public Task HardDeleteProductLocationByIdAsync(Guid id);

        public Task HardDeleteProductCategoriesByIdAsync(Guid id);

        public Task HardDeleteProductImagesByIdAsync(Guid id);

        public ICollection<Product> ReturnAll();

        public Task CreatingProductCategoryAsync(ICollection<int> categories, Guid product);

        public Task CreatingProductLocationAsync(ICollection<int> locations, Guid product);

        public Task CreatingProductImageAsync(ICollection<string> paths, Guid product);


        public Task CreatingProductSizeAsync(ICollection<int> sizes, Guid product);

        public Task CreatingProductColorAsync(ICollection<int> colors, Guid product);



        public int GetProductCount();

        public Product GetProductById(Guid id);
        public ProductOutputViewModel GetOutputProductById(Guid id);


        public Task EditAsync(ProductEditViewModel viewModel);


        public ICollection<Location> GetLocationsByProductId(Guid id);
        public ICollection<Category> GetCategoriesByProductId(Guid id);
        public ICollection<ProductImage> GetImagesByProductId(Guid id);




    }
}
