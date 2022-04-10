using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteX.Data.Models;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels.CategoryModels;
using SiteX.Web.ViewModels.ShopViewModels.ColorModels;
using SiteX.Web.ViewModels.ShopViewModels.LocationModels;
using SiteX.Web.ViewModels.ShopViewModels.ProductModels;
using SiteX.Web.ViewModels.ShopViewModels.SizeModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SiteX.Web.Controllers
{
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
            IProductLocationService productLocationService)
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
        }


        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [Authorize]
        public async Task<IActionResult> RemoveProduct()
        {
            this.ViewBag.Products = new SelectList(productService.ReturnAll(), "Id", "Name");
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> RemoveProduct(SelectProductViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            await productService.SoftDeleteProductByIdAsync(model.ProductId);
            return Redirect("/");
        }



        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateProduct()
        {
            var viewModel= new ProductViewModel();
 

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
        public async Task<IActionResult> SelectEditProduct()
        {
            this.ViewBag.Products = new SelectList(productService.ReturnAll(), "Id", "Name");
            return this.View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> SelectEditProduct(SelectProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            return this.RedirectToAction("EditProduct", model);
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditProduct(SelectProductViewModel model)
        {

            // TODO Fix ViewBAG problem

            var viewModel = productService.GetProductById(model.ProductId);

            var EditedViewModel = new ProductEditViewModel() { OldProductId = model.ProductId };
            EditedViewModel.OldProduct = viewModel;

            var locations = locationService.GetLocationsByProductId(EditedViewModel.OldProduct.Id);
            var categories = categoryService.GetCategoriesByProductId(EditedViewModel.OldProduct.Id);
            var pictures = pictureService.GetImagesByProductId(EditedViewModel.OldProduct.Id);
            var colors = colorService.GetColorsByProductId(EditedViewModel.OldProduct.Id);
            var sizes = sizeService.GetSizesByProductId(EditedViewModel.OldProduct.Id);


            EditedViewModel.Categories = categories.Select(x => x.Id).ToList();
            EditedViewModel.Locations = locations.Select(x => x.Id).ToList();
            EditedViewModel.Pictures = pictures.Select(x => x.Path).ToList();
            EditedViewModel.Colors = colors.Select(x => x.Id).ToList();
            EditedViewModel.Sizes = sizes.Select(x => x.Id).ToList();

            if (EditedViewModel.Pictures.Count() == 0)
            {
                EditedViewModel.Pictures.Add(string.Empty);
            }

            

            EditedViewModel.GendersToList = this.genderService.GetGenders();
            EditedViewModel.CategoriesToList = this.categoryService.GetCategories();
            EditedViewModel.LocationsToList = this.locationService.GetLocations();
            EditedViewModel.SizesToList = this.sizeService.GetSizes();
            EditedViewModel.ColorsToList = this.colorService.GetColors();


            this.ViewBag.CategoriesCount = categoryService.GetCategoryCount();
            this.ViewBag.ProductId = viewModel.Id;

            return this.View(EditedViewModel);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        // PRODUCT ID AND OLD PRODUCT DIDNT SHOW AFTER HTTP POST SO I ADDED FROMQUERY ATTRIBUTE TO BIND IT AFTER
        public async Task<IActionResult> EditProduct(ProductEditViewModel viewModel, [FromQuery(Name = "ProductId")] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            viewModel.OldProductId = id;
            await productService.EditAsync(viewModel);

            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateCategory()
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
        public async Task<IActionResult> EditCategory()
        {
            var viewModel = new CategoryEditViewModel();
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            return this.View(viewModel);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            await categoryService.EditAsync(viewModel);

            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateColor()
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
        public async Task<IActionResult> CreateSize()
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
        public async Task<IActionResult> CreateLocation()
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
        public async Task<IActionResult> EditLocation()
        {
            var viewModel = new LocationEditViewModel();
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations(), "Id", "Address");
            return this.View(viewModel);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> EditLocation(LocationEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            await locationService.EditAsync(viewModel);

            return this.Redirect("/");
        }


        public async Task<IActionResult> All(int id = 1)
        {
            ProductAllViewModel productViewModel = new ProductAllViewModel() { Products = productService.ToPage(id, 6), PageNumber = id, ItemsPerPage = 6 };
            productViewModel.RecipesCount = productService.GetProductCount();
            return this.View(productViewModel);

        }

        public IActionResult SearchByCategory(int id = 1)
        {

            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = productService.FilterByCategoryId(id)
            };
            if (productViewModel != null)
            {
                return this.View("All", productViewModel);

            }
            return NotFound();
        }

        public IActionResult SearchByGender(string id="Male")
        {

            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = productService.FilterByGenderId(id)
            };
            if (productViewModel != null)
            {
                return this.View("All", productViewModel);

            }
            return NotFound();
        }

        public IActionResult SearchByColor(int id = 1)
        {

            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = productService.FilterByColorId(id)
            };
            if (productViewModel != null)
            {
                return this.View("All", productViewModel);

            }
            return NotFound();
        }
        public IActionResult SearchBySize(int id = 1)
        {

            ProductAllViewModel productViewModel = new ProductAllViewModel()
            {
                Products = productService.FilterBySizeId(id)
            };
            if (productViewModel != null)
            {
                return this.View("All",productViewModel);

            }
            return NotFound();
        }

      

        public IActionResult ById(Guid id)
        {
            var product = this.productService.GetOutputProductById(id);
            ViewBag.ImageOne = productImageService.GetImagesByProductId(id).Select(x => x.Path).FirstOrDefault();
            ViewBag.Images = productImageService.GetImagesByProductId(id).Select(x => x.Path).Skip(1);
            var viewmodel= new BuyingProductViewModel() {ProductId=product.Id,Product=product};

            viewmodel.CategoriesToList = product.Categories;
            viewmodel.LocationsToList = product.Locations;
            viewmodel.SizesToList = product.Sizes;
            viewmodel.ColorsToList = product.Colors;
             

            return this.View(viewmodel);
        }

        [HttpPost]
        public IActionResult ById(BuyingProductViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            return RedirectToAction("Buy",viewmodel);
        }

        public IActionResult Buy()
        {

            return this.View();
        }

    }
}
