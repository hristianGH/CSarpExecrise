namespace SiteX.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SiteX.Data.Models;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels.ProductModels;

    public class ShopController : Controller
    {
        private readonly IProductService productService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProductImageService productImageService;
        private readonly IShopListService toListService;

        // TODO IdeletableEntityRepository
        public ShopController(
            IProductService productService,
            UserManager<ApplicationUser> userManager,
            IProductImageService productImageService,
            IShopListService toListService)
        {
            this.productService = productService;
            this.userManager = userManager;
            this.productImageService = productImageService;
            this.toListService = toListService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
 

        [Authorize(Roles = "Administrator")]
        public IActionResult SelectEditProduct()
        {
            this.ViewBag.Products = new SelectList(this.productService.ReturnAll(), "Id", "Name");
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult SelectEditProduct(SelectProductViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            return this.RedirectToAction("EditProduct", model);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreateColor()
        {
            return this.View();
        }

        public IActionResult All(int id = 1)
        {
            ProductAllViewModel productViewModel = new ProductAllViewModel() { Products = this.productService.ToPage(id, 6), PageNumber = id, ItemsPerPage = 6 };
            productViewModel.ItemsCount = this.productService.GetProductCount();
            productViewModel.ToSelectList = this.toListService.ToSelectList();
            return this.View(productViewModel);
        }

        public IActionResult SearchByCategory(int id = 1)
        {
            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = this.productService.FilterByCategoryId(id),
            };
            productViewModel.ItemsCount = this.productService.GetProductCount();
            productViewModel.ToSelectList = this.toListService.ToSelectList();

            if (productViewModel != null)
            {
                return this.View("All", productViewModel);
            }

            return this.NotFound();
        }

        public IActionResult SearchByGender(string id = "Male")
        {
            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = this.productService.FilterByGenderId(id),
            };

            productViewModel.ItemsCount = this.productService.GetProductCount();
            productViewModel.ToSelectList = this.toListService.ToSelectList();

            if (productViewModel != null)
            {
                return this.View("All", productViewModel);
            }

            return this.NotFound();
        }

        public IActionResult SearchByColor(int id = 1)
        {
            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = this.productService.FilterByColorId(id),
            };
            productViewModel.ItemsCount = this.productService.GetProductCount();
            productViewModel.ToSelectList = this.toListService.ToSelectList();

            if (productViewModel != null)
            {
                return this.View("All", productViewModel);
            }

            return this.NotFound();
        }

        public IActionResult SearchBySize(int id = 1)
        {
            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = this.productService.FilterBySizeId(id),
            };
            productViewModel.ItemsCount = this.productService.GetProductCount();
            productViewModel.ToSelectList = this.toListService.ToSelectList();

            if (productViewModel != null)
            {
                return this.View("All", productViewModel);
            }

            return this.NotFound();
        }

        public IActionResult ById(Guid id)
        {
            var product = this.productService.GetOutputProductById(id);
            this.ViewBag.ImageOne = this.productImageService.GetImagesByProductId(id).Select(x => x.Path).FirstOrDefault();
            this.ViewBag.Images = this.productImageService.GetImagesByProductId(id).Select(x => x.Path).Skip(1);
            var viewmodel = new BuyingProductViewModel() { ProductId = product.Id, Product = product };

            viewmodel.CategoriesToList = product.Categories;
            viewmodel.LocationsToList = product.Locations;
            viewmodel.SizesToList = product.Sizes;
            viewmodel.ColorsToList = product.Colors;

            return this.View(viewmodel);
        }

        [HttpPost]
        public IActionResult ById(BuyingProductViewModel viewmodel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            return this.RedirectToAction("Buy", viewmodel);
        }

        public IActionResult Buy(BuyingProductViewModel viewModel)
        {
            var prod = viewModel.Product;
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Buy(Product viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productService.BuyProductAsync(viewModel);
            return this.RedirectToAction("All");
        }
    }
}
