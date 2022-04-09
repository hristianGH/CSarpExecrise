using Microsoft.EntityFrameworkCore;
using SiteX.Data.Common.Models;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService
{
    public class ProductService : IProductService
    {
        private readonly IDeletableEntityRepository<Product> productRepo;
        private readonly IDeletableEntityRepository<ProductCategory> productCategoryRepo;
        private readonly IDeletableEntityRepository<ProductLocation> productLocationRepo;
        private readonly IDeletableEntityRepository<ProductSize> prodSizeRepo;
        private readonly IDeletableEntityRepository<ProductImage> prodImageRepo;
        private readonly IDeletableEntityRepository<ProductColor> prodColorRepo;


        public ProductService(IDeletableEntityRepository<Product> productRepo,
            IDeletableEntityRepository<ProductCategory> productCategoryRepo,
            IDeletableEntityRepository<ProductLocation> productLocationRepo,
            IDeletableEntityRepository<ProductImage> prodImageRepo,
            IDeletableEntityRepository<ProductColor> prodColorRepo,
            IDeletableEntityRepository<ProductSize> prodSizeRepo)
        {
            this.productRepo = productRepo;
            this.productCategoryRepo = productCategoryRepo;
            this.productLocationRepo = productLocationRepo;
            this.prodSizeRepo = prodSizeRepo;
            this.prodImageRepo = prodImageRepo;
            this.prodColorRepo = prodColorRepo;
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
                Price = viewModel.Price,
                ProductImages = pics,

            };

            await this.productRepo.AddAsync(product);
            await this.productRepo.SaveChangesAsync();

            await CreatingProductCategoryAsync(viewModel.Categories, product.Id);
            await CreatingProductLocationAsync(viewModel.Locations, product.Id);
            await CreatingProductColorAsync(viewModel.Colors, product.Id);
            await CreatingProductSizeAsync(viewModel.Sizes, product.Id);



        }

        public async Task RemoveALLAsync()
        {
            var all = productRepo.All().ToArray();
            for (int i = 0; i < all.Length - 1; i++)
            {
                productRepo.Delete(all[i]);
            }
           await productRepo.SaveChangesAsync();

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


        public async Task SoftDeleteProductByIdAsync(Guid id)
        {
            var product = productRepo.All().Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
            {
                await RemoveProductAsync(product);
                 
            }
        }


        public ICollection<ProductOutputViewModel> ToPage(int page = 1, int itemsPerPage = 6)
        {
            var output = this.GetAllProductsAsOutModel().Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            return output;
        }

        public ICollection<ProductOutputViewModel> GetAllProductsAsOutModel()
        {
            var output = this.productRepo.AllAsNoTracking().OrderByDescending(x => x.CreatedOn)
                .Select(x => new ProductOutputViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Categories = x.ProductCategories.Select(x => x.Category).ToList(),
                    ImageUrl = x.ProductImages.OrderBy(x => x.Id).Select(x => x.Path).FirstOrDefault(),
                    Locations = x.ProductLocations.Select(x => x.Location).ToList(),
                    Colors = x.ProductColors.Select(x => x.Color).ToList(),
                    Sizes = x.ProductSizes.Select(x => x.Size).ToList(),
                    Description = x.Description,
                    Gender = x.Gender,
                    Price = x.Price

                }).ToList();
            return output;
        }


        // TODO MAKE CREATE GENERIC

        public async Task CreatingProductLocationAsync(ICollection<int> locations, Guid product)
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
        // TODO MAKE CREATE GENERIC

        public async Task CreatingProductCategoryAsync(ICollection<int> categories, Guid product)
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
        // TODO MAKE CREATE GENERIC

        public async Task CreatingProductImageAsync(ICollection<string> paths, Guid product)
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
        // TODO MAKE CREATE GENERIC
        public async Task CreatingProductSizeAsync(ICollection<int> sizes, Guid product)
        {
            foreach (var item in sizes)
            {
                var entity = new ProductSize();
                entity.ProductId = product;
                entity.SizeId = item;

                await this.prodSizeRepo.AddAsync(entity);
            }
            await this.prodSizeRepo.SaveChangesAsync();
        }
        // TODO MAKE CREATE GENERIC

        public async Task CreatingProductColorAsync(ICollection<int> colors, Guid product)
        {
            foreach (var item in colors)
            {
                var entity = new ProductColor();
                entity.ProductId = product;
                entity.ColorId = item;

                await this.prodColorRepo.AddAsync(entity);
            }
            await this.prodColorRepo.SaveChangesAsync();
        }

        public int GetProductCount()
        {
            return this.productRepo.AllAsNoTracking().Count();
        }

        public Product GetProductById(Guid id)
        {

            return this.productRepo.AllAsNoTracking().Where(x => x.Id == id).FirstOrDefault();

        }

        public ProductOutputViewModel GetOutputProductById(Guid id)
        {
            var output = this.GetAllProductsAsOutModel().Where(x => x.Id == id).FirstOrDefault();
            return output;
        }


        public async Task EditAsync(ProductEditViewModel viewModel)
        {

            var product = this.productRepo.All().Where(x => x.Id == viewModel.OldProductId).FirstOrDefault();
            product.Name = viewModel.Name;
            product.Description = viewModel.Description;
            product.Price = viewModel.Price;
            product.Gender = viewModel.Gender;

            await this.productRepo.SaveChangesAsync();

            HardDeleteProductLocationByIdAsync(viewModel.OldProductId);

            HardDeleteProductCategoriesByIdAsync(viewModel.OldProductId);

            HardDeleteProductImagesByIdAsync(viewModel.OldProductId);



            await CreatingProductCategoryAsync(viewModel.Categories, product.Id);
            await CreatingProductLocationAsync(viewModel.Locations, product.Id);
            await CreatingProductImageAsync(viewModel.Pictures, product.Id);



        }

        public async Task HardDeleteProductLocationByIdAsync(Guid productId)
        {
            var locations = productLocationRepo.All().Where(x => x.ProductId == productId).ToList();
            foreach (var location in locations)
            {
                productLocationRepo.HardDelete(location);
            }
            await productLocationRepo.SaveChangesAsync();
        }

        public async Task HardDeleteProductCategoriesByIdAsync(Guid productId)
        {
            var categories = productCategoryRepo.All().Where(x => x.ProductId == productId).ToList();
            foreach (var category in categories)
            {
                productCategoryRepo.HardDelete(category);
            }
            await productCategoryRepo.SaveChangesAsync();
            categories = productCategoryRepo.All().Where(x => x.ProductId == productId).ToList();

        }

        public async Task HardDeleteProductImagesByIdAsync(Guid productId)
        {
            var images = prodImageRepo.All().Where(x => x.Product.Id == productId).ToList();
            foreach (var image in images)
            {
                prodImageRepo.HardDelete(image);
            }
            await prodImageRepo.SaveChangesAsync();

        }

        public ICollection<Location> GetLocationsByProductId(Guid id)
        {
            return productLocationRepo.AllAsNoTracking().Where(x => x.ProductId == id).Select(x => x.Location).ToList();
        }

        public ICollection<Category> GetCategoriesByProductId(Guid id)
        {
            return productCategoryRepo.AllAsNoTracking().Where(x => x.ProductId == id).Select(x => x.Category).ToList();

        }

        public ICollection<ProductImage> GetImagesByProductId(Guid id)
        {
            return prodImageRepo.AllAsNoTracking().Where(x => x.ProductId == id).ToList();

        }

        public ICollection<ProductOutputViewModel> SortedByCategoryId(int id)
        {
            var products = this.GetAllProductsAsOutModel().Where(x => x.Categories.Any(x => x.Id == id)).ToList();
            return products;
        }
    }

}
