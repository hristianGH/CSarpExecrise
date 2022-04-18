namespace SiteX.Services.Data.ShopService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Shop;
    using SiteX.Web.ViewModels.ShopViewModels.ProductModels;

    public interface IProductService
    {
        public Task CreateAsync(ProductViewModel viewModel);

        public ICollection<ProductOutputViewModel> ToPage(int page = 1, int itemsPerPage = 6);

        public ICollection<ProductOutputViewModel> GetAllProductsAsOutModel();

        public ICollection<ProductOutputViewModel> FilterByCategoryId(int id);

        public ICollection<ProductOutputViewModel> FilterByGenderId(string gender);

        public ICollection<ProductOutputViewModel> FilterBySizeId(int id);

        public ICollection<ProductOutputViewModel> FilterByColorId(int id);

        public Task RemoveProductAsync(Product product);

        public Task RemoveALLAsync();

        public Task SoftDeleteProductByIdAsync(Guid id);

        public ICollection<Product> ReturnAll();

        public int GetProductCount();

        public Product GetProductById(Guid id);

        public ICollection<Product> GetProducts();

        public ProductOutputViewModel GetOutputProductById(Guid id);

        public ProductEdit GetProductEditById(Guid id);

        public Task EditAsync(ProductEditViewModel viewModel);

        public Task EditProductAsync(ProductEdit viewModel);

        public Task HardDeleteConnectionsByProductIdAsync(Guid id);

        public Task CreateConnectionsByModelAsync(ProductEdit list, Guid id);

        public Task BuyProductAsync(Product product);
    }
}
