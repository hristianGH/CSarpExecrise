using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteX.Data;
using SiteX.Data.Models;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SiteX.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IGenderService genderService;
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly ILocationService locationService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPictureService pictureService;



        // TODO IdeletableEntityRepository
        public ShopController(
            ApplicationDbContext dbContext,
            IGenderService genderService,
            ICategoryService categoryService,
            IProductService productService,
            ILocationService locationService,
            UserManager<ApplicationUser> userManager,
            IPictureService pictureService)
        {
            dbcontext = dbContext;
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.productService = productService;
            this.locationService = locationService;
            this.userManager = userManager;
            this.pictureService = pictureService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> CreateProduct()
        {
            this.ViewBag.Genders = new SelectList(this.genderService.GetGenders());
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations(), "Id", "Address");

            return this.View();

        }


        [Authorize]
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

        [Authorize]
        public async Task<IActionResult> SelectEditProduct()
        {
            this.ViewBag.Products = new SelectList(productService.ReturnAll(), "Id", "Name");
            return this.View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SelectEditProduct(SelectProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            return this.RedirectToAction("EditProduct", model);
        }

        [Authorize]
        public async Task<IActionResult> EditProduct(SelectProductViewModel model)
        {
            var viewModel = productService.GetProductById(model.ProductId);

            var EditedViewModel = new ProductEditViewModel() {OldProductId=model.ProductId };
            EditedViewModel.OldProduct = viewModel;

            var locations = locationService.GetLocationsByProductId(EditedViewModel.OldProduct.Id);
            var categories = categoryService.GetCategoriesByProductId(EditedViewModel.OldProduct.Id);
            var pictures = pictureService.GetImagesByProductId(EditedViewModel.OldProduct.Id);

            EditedViewModel.Categories = categories.Select(x => x.Id).ToList();
            EditedViewModel.Locations = locations.Select(x => x.Id).ToList();
            EditedViewModel.Pictures = pictures.Select(x => x.Path).ToList();
            if (EditedViewModel.Pictures.Count()==0)
            {
                EditedViewModel.Pictures.Add("");
            }
            this.ViewBag.Genders = new SelectList(this.genderService.GetGenders());
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations(), "Id", "Address");
            this.ViewBag.CategoriesId = categories.Select(x => x.Id).ToList();
            this.ViewBag.LocationsId = locations.Select(x => x.Id).ToList();
            this.ViewBag.CategoriesCount = categoryService.GetCategoryCount();
            this.ViewBag.ProductId = viewModel.Id;

            return this.View(EditedViewModel);
        }

        [Authorize]
        [HttpPost]
        // PRODUCT ID AND OLD PRODUCT DIDNT SHOW AFTER HTTP POST SO I ADDED FROMQUERY ATTRIBUTE TO BIND IT AFTER
        public async Task<IActionResult> EditProduct(ProductEditViewModel viewModel,[FromQuery(Name = "ProductId")]Guid id )
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            viewModel.OldProductId = id;
            await productService.EditAsync(viewModel);

            return this.Redirect("/");
        }

        [Authorize]
        public async Task<IActionResult> CreateCategory()
        {

            return this.View();

        }


        [Authorize]
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

        [Authorize]
        public async Task<IActionResult> EditCategory()
        {
            var viewModel = new CategoryEditViewModel();
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            return this.View(viewModel);
        }
        [Authorize]
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



        [Authorize]
        public async Task<IActionResult> CreateLocation()
        {

            return this.View();

        }

        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> EditLocation()
        {
            var viewModel = new LocationEditViewModel();
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations(), "Id", "Address");
            return this.View(viewModel);
        }
        [Authorize]
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
            ProductAllViewModel productViewModel = new ProductAllViewModel() { Products = productService.ToList(id, 6), PageNumber = id, ItemsPerPage = 6 };
            productViewModel.RecipesCount = productService.GetProductCount();
            return this.View(productViewModel);

        }
        public IActionResult ProductById(Guid id)
        {
            var product = productService.GetProductById(id);
            return this.View(product);
        }
    }
}
