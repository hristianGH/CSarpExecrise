using Microsoft.EntityFrameworkCore;
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
        private readonly IRepository<ProductLocation> productLocationRepo;
        private readonly IRepository<Category> categoryRepo;

        public ProductService(IDeletableEntityRepository<Product> productRepo,
            IRepository<ProductCategory> productCategoryRepo,
            IRepository<ProductLocation> productLocationRepo,
            IRepository<Category> categoryRepo
            )
        {
            this.productRepo = productRepo;
            this.productCategoryRepo = productCategoryRepo;
            this.productLocationRepo = productLocationRepo;
            this.categoryRepo = categoryRepo;
        }
        public async Task CreateAsync(ProductViewModel viewModel)
        {
            var pics = new List<ProductImage>();
            foreach (var pic in viewModel.Pictures.Where(x => x != null))
            {
                pics.Add(new ProductImage() { Path = pic });
            }
            var product = new Product
            {
                Name = viewModel.Name,
                User = viewModel.User,
                Description = viewModel.Description,
                Gender = viewModel.Gender,
                //Locations = viewModel.Locations, 
                //TODO ADD LOCATIONS 
                Price = viewModel.Price,
                ProductImages = pics,

            };

            await this.productRepo.AddAsync(product);
            await this.productRepo.SaveChangesAsync();

            await CreatingProductCategory(viewModel, product);
            await CreatingProductLocation(viewModel, product);


        }

        public async Task   RemoveALLAsync()
        {
            var all = productRepo.All().ToArray();
            for (int i = 0; i < all.Length-1; i++)
            {
                productRepo.Delete(all[i]);
            }
            productRepo.SaveChangesAsync();

        }
        public List<Product> ReturnAll()
        {
            var prods = new List<Product>();
            foreach (var product in productRepo.AllAsNoTracking())
            {

                prods.Add(product);
            }
            return prods;
        }

        public async Task RemoveProductAsync(Product product)
        {
            product.IsAvalable = false;
            productRepo.Delete(product);
            await productRepo.SaveChangesAsync();
        }

        public ICollection<ProductOutputViewModel> ToList(int page=1, int itemsPerPage = 6)
        {
            var output = this.productRepo.AllAsNoTracking().OrderByDescending(x => x.CreatedOn)
                .Select(x => new ProductOutputViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Categories = x.ProductCategories.Select(x => x.Category).ToList(),
                    ImageUrl = x.ProductImages.OrderBy(x => x.Id).Select(x => x.Path).FirstOrDefault(),
                    Locations = x.ProductLocations.Select(x => x.Location).ToList(),
                    Description = x.Description,
                    Price = x.Price
                }).Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            return output;
        }

        public async Task CreatingProductLocation(ProductViewModel viewModel, Product product)
        {
            foreach (var item in viewModel.Locations)
            {
                var entity = new ProductLocation();
                entity.ProductId = product.Id;
                entity.LocationId = item;

                await this.productLocationRepo.AddAsync(entity);
            }
            await this.productLocationRepo.SaveChangesAsync();
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

        public int GetProductCount()
        {
           return productRepo.AllAsNoTracking().Count();
        }

        public Product GetProductById(Guid id)
        {
           return productRepo.AllAsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}