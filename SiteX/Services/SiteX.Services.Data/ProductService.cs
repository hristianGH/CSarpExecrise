using SiteX.Data.Common.Models;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly IDeletableEntityRepository<Product> productRepo;

        public ProductService(IDeletableEntityRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }
        public async Task CreateAsync(ProductViewModel viewModel)
        {
            var product = new Product
            {
                Name = viewModel.Name,
                User = viewModel.User,
                Categories = viewModel.Categories,
                Description = viewModel.Description,
                Gender = new Gender() {Name=viewModel.Gender.Split(",")[1] },
                Locations = viewModel.Locations,
                Price = viewModel.Price,
                Pictures = viewModel.Pictures
            };
            await this.productRepo.AddAsync(product);
            await this.productRepo.SaveChangesAsync();
        }
    }
}
