using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteX.Data;
using SiteX.Services.Data;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SiteX.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IGenderToDictionary genderService;
        private readonly ICategoryToDictionary categoryService;
        private readonly IProductService productService;



        //TODO IdeletableEntityRepository
        public ShopController(ApplicationDbContext dbContext,
            IGenderToDictionary genderService,
            ICategoryToDictionary categoryService,
            IProductService productService)
        {
            dbcontext = dbContext;
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.productService = productService;
        }


        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel() { };
            return View();
        }

        [Authorize]
        public async Task<IActionResult> CreateProduct()
        {
            this.ViewBag.Genders = new SelectList(this.genderService.GetGenderAsKVP());
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategoryAsKVP());

             return this.View();

        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel viewModel)
        {
             
            if (this.ModelState.IsValid)
            {
                var username = this.User.Identity.Name;

                viewModel.User = this.dbcontext.Users.FirstOrDefault(x => x.UserName == username);

                this.ViewBag.Genders = new SelectList(this.genderService.GetGenderAsKVP());
                this.ViewBag.Categories = new SelectList(this.categoryService.GetCategoryAsKVP());

                await this.productService.CreateAsync(viewModel);
            }
            return this.Redirect("/");
        }

    }
}
