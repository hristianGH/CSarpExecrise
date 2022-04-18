namespace SiteX.Services.Data.ShopService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels.ProductModels;

    public class ProductService : IProductService
    {
        private readonly IDeletableEntityRepository<Product> productRepo;
        private readonly IProductCategoryService productCategoryService;
        private readonly IProductLocationService productLocationService;
        private readonly IProductSizeService productSizeService;
        private readonly IProductColorService productColorService;
        private readonly IProductImageService productImageService;
        private readonly IReceitService receitService;

        public ProductService(
            IDeletableEntityRepository<Product> productRepo,
            IProductCategoryService productCategoryService,
            IProductLocationService productLocationService,
            IProductSizeService productSizeService,
            IProductColorService productColorService,
            IProductImageService productImageService,
            IReceitService receitService)
        {
            this.productRepo = productRepo;

            this.productCategoryService = productCategoryService;
            this.productLocationService = productLocationService;
            this.productSizeService = productSizeService;
            this.productColorService = productColorService;
            this.productImageService = productImageService;
            this.receitService = receitService;
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
                Quantity = viewModel.Quantity,
            };

            await this.productRepo.AddAsync(product);
            await this.productRepo.SaveChangesAsync();
            await this.productCategoryService.CreatingProductCategoryAsync(viewModel.Categories, product.Id);
            await this.productLocationService.CreatingProductLocationAsync(viewModel.Locations, product.Id);
            await this.productColorService.CreatingProductColorAsync(viewModel.Colors, product.Id);
            await this.productSizeService.CreatingProductSizeAsync(viewModel.Sizes, product.Id);
        }

        public async Task RemoveALLAsync()
        {
            var all = this.productRepo.All().ToArray();
            for (int i = 0; i < all.Length - 1; i++)
            {
                this.productRepo.Delete(all[i]);
            }

            await this.productRepo.SaveChangesAsync();
        }

        public ICollection<Product> ReturnAll()
        {
            var products = this.productRepo.AllAsNoTracking().OrderByDescending(x => x.CreatedOn).ToList();

            return products;
        }

        public async Task RemoveProductAsync(Product product)
        {
            product.IsAvalable = false;
            this.productRepo.Delete(product);
            await this.productRepo.SaveChangesAsync();
        }

        public async Task SoftDeleteProductByIdAsync(Guid id)
        {
            var product = this.productRepo.All().Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
            {
                await this.RemoveProductAsync(product);
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
                    Quantity = x.Quantity,
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

            await this.productColorService.CreatingProductColorAsync(viewModel.Colors, product.Id);

            await this.productSizeService.CreatingProductSizeAsync(viewModel.Sizes, product.Id);
        }

        public ICollection<ProductOutputViewModel> FilterByCategoryId(int id)
        {
            var products = this.GetAllProductsAsOutModel().Where(x => x.Categories.Any(x => x.Id == id)).ToList();
            return products;
        }

        public ICollection<ProductOutputViewModel> FilterByGenderId(string gender)
        {
            var products = this.GetAllProductsAsOutModel().Where(x => x.Gender == gender).ToList();
            return products;
        }

        public ICollection<ProductOutputViewModel> FilterBySizeId(int id)
        {
            var products = this.GetAllProductsAsOutModel().Where(x => x.Sizes.Any(x => x.Id == id)).ToList();
            return products;
        }

        public ICollection<ProductOutputViewModel> FilterByColorId(int id)
        {
            var products = this.GetAllProductsAsOutModel().Where(x => x.Colors.Any(x => x.Id == id)).ToList();
            return products;
        }

        public ICollection<Product> GetProducts()
        {
            return this.productRepo.AllAsNoTracking().ToList();
        }

        public async Task EditProductAsync(ProductEdit viewModel)
        {
            var product = this.productRepo.All().Where(x => x.Id == viewModel.Id).FirstOrDefault();
            product.Name = viewModel.Name;
            product.Description = viewModel.Description;
            product.Price = viewModel.Price;
            product.Gender = viewModel.Gender;
            product.Quantity = viewModel.Quantity;

            await this.productRepo.SaveChangesAsync();

            await this.HardDeleteConnectionsByProductIdAsync(viewModel.Id);
            await this.CreateConnectionsByModelAsync(viewModel, viewModel.Id);
        }

        public ProductEdit GetProductEditById(Guid id)
        {
            var edit = this.productRepo.AllAsNoTracking().Select(x => new ProductEdit
            {
                Id = x.Id,
                Name = x.Name,
                Categories = x.ProductCategories.Select(x => x.Category.Id).ToList(),
                Pictures = x.ProductImages.OrderBy(x => x.Id).Select(x => x.Path).ToList(),
                Locations = x.ProductLocations.Select(x => x.Location.Id).ToList(),
                Colors = x.ProductColors.Select(x => x.Color.Id).ToList(),
                Sizes = x.ProductSizes.Select(x => x.Size.Id).ToList(),
                Description = x.Description,
                Quantity = x.Quantity,
                Gender = x.Gender,
                Price = x.Price,
            }).Where(x => x.Id == id).FirstOrDefault();

            return edit;
        }

        public async Task HardDeleteConnectionsByProductIdAsync(Guid id)
        {
            await this.productLocationService.HardDeleteProductLocationByIdAsync(id);

            await this.productCategoryService.HardDeleteProductCategoriesByIdAsync(id);

            await this.productImageService.HardDeleteProductImagesByIdAsync(id);

            await this.productColorService.HardDeleteProductColorByIdAsync(id);

            await this.productSizeService.HardDeleteProductSizeByIdAsync(id);
        }

        public async Task CreateConnectionsByModelAsync(ProductEdit viewModel, Guid id)
        {
            await this.productCategoryService.CreatingProductCategoryAsync(viewModel.Categories, id);

            await this.productLocationService.CreatingProductLocationAsync(viewModel.Locations, id);

            await this.productImageService.CreatingProductImageAsync(viewModel.Pictures, id);

            await this.productColorService.CreatingProductColorAsync(viewModel.Colors, id);

            await this.productSizeService.CreatingProductSizeAsync(viewModel.Sizes, id);
        }

        public async Task BuyProductAsync(Product product)
        {
            var prod = this.productRepo.All().FirstOrDefault(x => x.Id == product.Id);
            if (prod.Quantity <= 1)
            {
                prod.IsAvalable = false;
                this.productRepo.Delete(prod);
            }
            Receit receit = new Receit()
            {
                Product = product,
                Price = product.Price,
                ProductId = product.Id,
                User = product.User,
                UserId = product.UserId,
                ProductName = product.Name,
            };

            await this.receitService.CreateAsync(receit);
            await this.productRepo.SaveChangesAsync();
        }
    }
}
