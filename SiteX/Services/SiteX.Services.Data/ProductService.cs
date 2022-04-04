using SiteX.Data.Common.Models;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly IDeletableEntityRepository<Product> productRepo;
        private readonly IRepository<ProductCategory> productCategoryRepo;

        public ProductService(IDeletableEntityRepository<Product> productRepo,
            IRepository<ProductCategory> productCategoryRepo)
        {
            this.productRepo = productRepo;
            this.productCategoryRepo = productCategoryRepo;
        }
        public async Task CreateAsync(ProductViewModel viewModel)
        {
            var pics = new List<Picture>();
            foreach (var pic in viewModel.Pictures.Where(x => x != null))
            {
                pics.Add(new Picture() { Path = pic });
            }
            var product = new Product
            {
                Name = viewModel.Name,
                User = viewModel.User,
                Description = viewModel.Description,
                Gender = viewModel.Gender,
                Locations = viewModel.Locations,
                Price = viewModel.Price,
                Pictures = pics,

            };

            await this.productRepo.AddAsync(product);
            await this.productRepo.SaveChangesAsync();

            await CreatingProductCategory(viewModel, product);

        }
        public async Task CreatingProductCategory(ProductViewModel viewModel, Product product)
        {
            foreach (var item in viewModel.Categories)
            {
                var entity = new ProductCategory();
                entity.ProductId = product.Id;
                entity.CategoryId = item;

                await this.productCategoryRepo.AddAsync(entity);
            }
            await this.productCategoryRepo.SaveChangesAsync();
        }

        public ICollection<ProductOutputViewModel> ToList(int page, int itemsPerPage = 6)
        {
            var output= this.productRepo.AllAsNoTracking().OrderByDescending(x => x.CreatedOn)
                .Select(x => new ProductOutputViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Category = x.ProductCategories.Select(x=>new Category() {Id=x.CategoryId }).FirstOrDefault(),
                    ImageUrl = x.Pictures.OrderBy(x => x.Id).Select(x => x.Path).FirstOrDefault(),
                    Locations = x.Locations,
                    Price=x.Price
                }).Take(6).ToList();
            return output;
        }

        
    }
}