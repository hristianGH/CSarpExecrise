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
        private readonly IDeletableEntityRepository<ProductImage> prodImageRepo;

        public ProductService(IDeletableEntityRepository<Product> productRepo,
            IRepository<ProductCategory> productCategoryRepo,
            IRepository<ProductLocation> productLocationRepo,
            IRepository<Category> categoryRepo,
            IDeletableEntityRepository<ProductImage> prodImageRepo
            )
        {
            this.productRepo = productRepo;
            this.productCategoryRepo = productCategoryRepo;
            this.productLocationRepo = productLocationRepo;
            this.categoryRepo = categoryRepo;
            this.prodImageRepo = prodImageRepo;
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

            await CreatingProductCategory(viewModel.Categories, product.Id);
            await CreatingProductLocation(viewModel.Locations, product.Id);


        }

        public async Task RemoveALLAsync()
        {
            var all = productRepo.All().ToArray();
            for (int i = 0; i < all.Length - 1; i++)
            {
                productRepo.Delete(all[i]);
            }
            productRepo.SaveChangesAsync();

        }
        public ICollection<Product> ReturnAll()
        {
            var prods = new List<Product>();
            foreach (var product in productRepo.AllAsNoTracking().OrderByDescending(x => x.CreatedOn))
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

        public ICollection<ProductOutputViewModel> ToList(int page = 1, int itemsPerPage = 6)
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

        public async Task CreatingProductLocation(ICollection<int> locations, Guid product)
        {

            foreach (var item in locations)
            {
                var entity = new ProductLocation();
                entity.ProductId = product;
                entity.LocationId = item;

                await this.productLocationRepo.AddAsync(entity);
            }
            await this.productLocationRepo.SaveChangesAsync();
        }
        public async Task CreatingProductCategory(ICollection<int> categories, Guid product)
        {


            foreach (var item in categories)
            {
                var entity = new ProductCategory();
                entity.ProductId = product;
                entity.CategoryId = item;

                await this.productCategoryRepo.AddAsync(entity);
            }
            await this.productCategoryRepo.SaveChangesAsync();
        }

        public async Task CreatingProductImage(ICollection<string> paths, Guid product)
        {
            foreach (var item in paths)
            {
                var entity = new ProductImage();
                entity.ProductId = product;
                entity.Path = item;

                await this.prodImageRepo.AddAsync(entity);
            }
            await this.prodImageRepo.SaveChangesAsync();
        }

        public int GetProductCount()
        {
            return this.productRepo.AllAsNoTracking().Count();
        }

        public Product GetProductById(Guid id)
        {
            return this.productRepo.AllAsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task EditAsync(ProductEditViewModel viewModel)
        {

            var product = this.productRepo.All().Where(x => x.Id == viewModel.OldProductId).FirstOrDefault();
            product.Name = viewModel.Name;
            product.Description = viewModel.Description;
            product.Price = viewModel.Price;
            product.Gender = viewModel.Gender;

            await this.productRepo.SaveChangesAsync();

            RemoveProductLocationById(viewModel.OldProductId);

            RemoveProductCategoriesById(viewModel.OldProductId);

            RemoveProductImagesById(viewModel.OldProductId);



            await CreatingProductCategory(viewModel.Categories, product.Id);
            await CreatingProductLocation(viewModel.Locations, product.Id);
            await CreatingProductImage(viewModel.Pictures, product.Id);

           

        }

        public async Task RemoveProductLocationById(Guid productId)
        {
            var locations = productLocationRepo.All().Where(x => x.ProductId == productId).ToList();
            foreach (var location in locations)
            {
                productLocationRepo.Delete(location);
            }
            await productLocationRepo.SaveChangesAsync();
        }

        public async Task RemoveProductCategoriesById(Guid productId)
        {
            var categories = productCategoryRepo.All().Where(x => x.ProductId == productId).ToList();
            foreach (var category in categories)
            {
                productCategoryRepo.Delete(category);
            }
            await productCategoryRepo.SaveChangesAsync();
             categories = productCategoryRepo.All().Where(x => x.ProductId == productId).ToList();

        }

        public async Task RemoveProductImagesById(Guid productId)
        {
            var images = prodImageRepo.All().Where(x => x.Product.Id == productId).ToList();
            foreach (var image in images)
            {
                prodImageRepo.Delete(image);
            }
             await prodImageRepo.SaveChangesAsync();

        }


    }
}