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
    using SiteX.Web.ViewModels.ShopViewModels.CategoryModels;
    using SiteX.Web.ViewModels.ShopViewModels.ColorModels;
    using SiteX.Web.ViewModels.ShopViewModels.LocationModels;
    using SiteX.Web.ViewModels.ShopViewModels.ProductModels;
    using SiteX.Web.ViewModels.ShopViewModels.SizeModels;

    public class ShopController : Controller
    {
        private readonly IGenderService genderService;
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly ILocationService locationService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProductImageService pictureService;
        private readonly ISizeService sizeService;
        private readonly IColorService colorService;
        private readonly IProductImageService productImageService;
        private readonly IProductCategoryService productCategoryService;
        private readonly IProductLocationService productLocationService;
        private readonly IShopListService toListService;

        // TODO IdeletableEntityRepository
        public ShopController(
            IGenderService genderService,
            ICategoryService categoryService,
            IProductService productService,
            ILocationService locationService,
            UserManager<ApplicationUser> userManager,
            IProductImageService pictureService,
            ISizeService sizeService,
            IColorService colorService,
            IProductImageService productImageService,
            IProductCategoryService productCategoryService,
            IProductLocationService productLocationService,
            IShopListService toListService)
        {
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.productService = productService;
            this.locationService = locationService;
            this.userManager = userManager;
            this.pictureService = pictureService;
            this.sizeService = sizeService;
            this.colorService = colorService;
            this.productImageService = productImageService;
            this.productCategoryService = productCategoryService;
            this.productLocationService = productLocationService;
            this.toListService = toListService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [Authorize]
        public IActionResult RemoveProduct()
        {
            this.ViewBag.Products = new SelectList(this.productService.ReturnAll(), "Id", "Name");
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> RemoveProduct(SelectProductViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productService.SoftDeleteProductByIdAsync(model.ProductId);
            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreateProduct()
        {
            var viewModel = new ProductViewModel();
            viewModel.GendersToList = this.genderService.GetGenders();
            viewModel.CategoriesToList = this.categoryService.GetCategories();
            viewModel.LocationsToList = this.locationService.GetLocations();
            viewModel.SizesToList = this.sizeService.GetSizes();
            viewModel.ColorsToList = this.colorService.GetColors();
            return this.View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            viewModel.User = await this.userManager.GetUserAsync(this.User);

            await this.productService.CreateAsync(viewModel);
            return this.Redirect("/");
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
        public IActionResult EditProduct(SelectProductViewModel model)
        {
            var viewModel = this.productService.GetProductById(model.ProductId);

            var editedViewModel = new ProductEditViewModel() { OldProductId = model.ProductId };
            editedViewModel.OldProduct = viewModel;
            var locations = this.locationService.GetLocationsByProductId(editedViewModel.OldProduct.Id);
            var categories = this.categoryService.GetCategoriesByProductId(editedViewModel.OldProduct.Id);
            var pictures = this.pictureService.GetImagesByProductId(editedViewModel.OldProduct.Id);
            var colors = this.colorService.GetColorsByProductId(editedViewModel.OldProduct.Id);
            var sizes = this.sizeService.GetSizesByProductId(editedViewModel.OldProduct.Id);

            editedViewModel.Categories = categories.Select(x => x.Id).ToList();
            editedViewModel.Locations = locations.Select(x => x.Id).ToList();
            editedViewModel.Pictures = pictures.Select(x => x.Path).ToList();
            editedViewModel.Colors = colors.Select(x => x.Id).ToList();
            editedViewModel.Sizes = sizes.Select(x => x.Id).ToList();

            if (editedViewModel.Pictures.Count() == 0)
            {
                editedViewModel.Pictures.Add(string.Empty);
            }

            editedViewModel.GendersToList = this.genderService.GetGenders();
            editedViewModel.CategoriesToList = this.categoryService.GetCategories();
            editedViewModel.LocationsToList = this.locationService.GetLocations();
            editedViewModel.SizesToList = this.sizeService.GetSizes();
            editedViewModel.ColorsToList = this.colorService.GetColors();

            this.ViewBag.CategoriesCount = this.categoryService.GetCategoryCount();
            this.ViewBag.ProductId = viewModel.Id;

            return this.View(editedViewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductEditViewModel viewModel, [FromQuery(Name = "ProductId")] Guid id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            viewModel.OldProductId = id;
            await this.productService.EditAsync(viewModel);

            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult CreateCategory()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.categoryService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult EditCategory()
        {
            var viewModel = new CategoryEditViewModel();
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            return this.View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryEditViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.categoryService.EditAsync(viewModel);

            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreateColor()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateColor(ColorViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.colorService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreateSize()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateSize(SizeViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.sizeService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreateLocation()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateLocation(LocationViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.locationService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult EditLocation()
        {
            var viewModel = new LocationEditViewModel();
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations(), "Id", "Address");
            return this.View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EditLocation(LocationEditViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.locationService.EditAsync(viewModel);

            return this.Redirect("/");
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
