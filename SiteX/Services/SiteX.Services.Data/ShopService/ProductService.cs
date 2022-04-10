using Microsoft.EntityFrameworkCore;
using SiteX.Data.Common.Models;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Services.Data.ShopService.Models;
using SiteX.Web.ViewModels.ShopViewModels;
using SiteX.Web.ViewModels.ShopViewModels.ProductModels;
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
        private readonly IProductCategoryService productCategoryService;
        private readonly IProductLocationService productLocationService;
        private readonly IProductSizeService productSizeService;
        private readonly IProductColorService productColorService;
        private readonly IProductImageService productImageService;

        public ProductService(
            IDeletableEntityRepository<Product> productRepo,
            IProductCategoryService productCategoryService,
            IProductLocationService productLocationService,
            IProductSizeService productSizeService,
            IProductColorService productColorService,
            IProductImageService productImageService)
        {
            this.productRepo = productRepo;

            this.productCategoryService = productCategoryService;
            this.productLocationService = productLocationService;
            this.productSizeService = productSizeService;
            this.productColorService = productColorService;
            this.productImageService = productImageService;
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

            await productCategoryService.CreatingProductCategoryAsync(viewModel.Categories, product.Id);
            await productLocationService.CreatingProductLocationAsync(viewModel.Locations, product.Id);
            await productColorService.CreatingProductColorAsync(viewModel.Colors, product.Id);
            await productSizeService.CreatingProductSizeAsync(viewModel.Sizes, product.Id);



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
                    Price = x.Price,

                }).ToList();
            return output;
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

            await this.productLocationService.HardDeleteProductLocationByIdAsync(viewModel.OldProductId);

            await this.productCategoryService.HardDeleteProductCategoriesByIdAsync(viewModel.OldProductId);

            await this.productImageService.HardDeleteProductImagesByIdAsync(viewModel.OldProductId);

            await this.productCategoryService.CreatingProductCategoryAsync(viewModel.Categories, product.Id);

            await this.productLocationService.CreatingProductLocationAsync(viewModel.Locations, product.Id);

            await this.productImageService.CreatingProductImageAsync(viewModel.Pictures, product.Id);

        }

        public ICollection<ProductOutputViewModel> SortedByCategoryId(int id)
        {
            var products = this.GetAllProductsAsOutModel().Where(x => x.Categories.Any(x => x.Id == id)).ToList();
            return products;
        }

         
    }
}

 