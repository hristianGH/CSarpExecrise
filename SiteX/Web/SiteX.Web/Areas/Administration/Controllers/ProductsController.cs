namespace SiteX.Web.Areas.Administration.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SiteX.Data.Models;
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels.ProductModels;

    public class ProductsController : AdministrationController
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
        private readonly IToListService toListService;

        // TODO IdeletableEntityRepository
        public ProductsController(
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
            IToListService toListService)
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
            var products = this.productService.ReturnAll();
            return this.View(products);
        }

        public IActionResult Create()
        {
            var viewModel = new ProductViewModel();
            viewModel.GendersToList = this.genderService.GetGenders();
            viewModel.CategoriesToList = this.categoryService.GetCategories();
            viewModel.LocationsToList = this.locationService.GetLocations();
            viewModel.SizesToList = this.sizeService.GetSizes();
            viewModel.ColorsToList = this.colorService.GetColors();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            viewModel.User = await this.userManager.GetUserAsync(this.User);

            await this.productService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        public IActionResult Edit(Guid id)
        {
            var viewModel = this.productService.GetProductEditById(id);

            if (viewModel.Pictures.Count() == 0)
            {
                viewModel.Pictures.Add(string.Empty);
            }

            viewModel.GendersToList = this.genderService.GetGenders();
            viewModel.CategoriesToList = this.categoryService.GetCategories();
            viewModel.LocationsToList = this.locationService.GetLocations();
            viewModel.SizesToList = this.sizeService.GetSizes();
            viewModel.ColorsToList = this.colorService.GetColors();

            this.ViewBag.CategoriesCount = this.categoryService.GetCategoryCount();
            this.ViewBag.ProductId = viewModel.Id;

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductEdit viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productService.EditProductAsync(viewModel);

            return this.Redirect("/");
        }

        public IActionResult Delete(Guid id)
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
        public async Task<IActionResult> Delete(BuyingProductViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productService.SoftDeleteProductByIdAsync(model.ProductId);

            return this.Redirect("/");
        }

}
}
