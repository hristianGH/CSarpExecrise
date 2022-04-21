using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels.ProductModels;
using System;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiteX.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenderService genderService;
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly ILocationService locationService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ISizeService sizeService;
        private readonly IColorService colorService;

        public ProductController(
            IGenderService genderService,
            ICategoryService categoryService,
            IProductService productService,
            ILocationService locationService,
            UserManager<ApplicationUser> userManager,
            ISizeService sizeService,
            IColorService colorService)
        {
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.productService = productService;
            this.locationService = locationService;
            this.userManager = userManager;
            this.sizeService = sizeService;
            this.colorService = colorService;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            var products = this.productService.ReturnAll();
            return this.Ok(products);
        }

        [HttpGet]
        [Route("byid")]
        public IActionResult Byid(Guid id)
        {
            var product = this.productService.GetProductById(id);
            if (product != null)
            {
                return this.Ok(product);
            }
            return this.NotFound();
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            var viewModel = new ProductViewModel();
            viewModel.GendersToList = this.genderService.GetGenders();
            viewModel.CategoriesToList = this.categoryService.GetCategories();
            viewModel.LocationsToList = this.locationService.GetLocations();
            viewModel.SizesToList = this.sizeService.GetSizes();
            viewModel.ColorsToList = this.colorService.GetColors();
            return this.Ok(viewModel);
        }

        [HttpPost]
        [Route("Create")]
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

        [HttpGet]
        [Route("Edit")]
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

            return this.Ok(viewModel);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(ProductViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productService.EditProductAsync(viewModel);

            return this.Redirect("/");
        }

        [HttpGet]
        [Route("Delete")]
        public IActionResult Delete(Guid id)
        {
            var product = this.productService.GetOutputProductById(id);
            var viewmodel = new BuyingProductViewModel() { ProductId = product.Id, Product = product };

            viewmodel.CategoriesToList = product.Categories;
            viewmodel.LocationsToList = product.Locations;
            viewmodel.SizesToList = product.Sizes;
            viewmodel.ColorsToList = product.Colors;
            return this.Ok(viewmodel);
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(BuyingProductViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productService.SoftDeleteProductByIdAsync(model.ProductId);

            return this.Ok();
        }
    }
}
