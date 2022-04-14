using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels.CategoryModels;
using System.Threading.Tasks;

namespace SiteX.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var categories = this.categoryService.GetCategories();
            return this.Ok(categories);
        }
        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            return this.Ok(new CategoryViewModel());
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CategoryViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.categoryService.CreateAsync(viewModel);
            return this.Redirect("/");
        }
        [HttpGet]
        [Route("Edit")]
        public IActionResult Edit(int id)
        {
            var viewModel = this.categoryService.GetCategoryById(id);
            return this.Ok(viewModel);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(Category viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.categoryService.EditCategoryAsync(viewModel);

            return this.Ok(viewModel);
        }

    }
}
