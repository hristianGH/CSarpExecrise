using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteX.Data;
using SiteX.Services.Data;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System.Linq;

namespace SiteX.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IGenderToDictionary genderService;
        private readonly ICategoryToDictionary categoryService;



        //TODO IdeletableEntityRepository
        public ShopController(ApplicationDbContext dbContext, IGenderToDictionary genderService, ICategoryToDictionary categoryService)
        {
            dbcontext = dbContext;
            this.genderService = genderService;
            this.categoryService = categoryService;
        }


        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel() { };
            return View();
        }

        [Authorize]
        public IActionResult CreateProduct()
        {
            this.ViewBag.Genders = new SelectList(this.genderService.GetGenderAsKVP());
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategoryAsKVP());

            return this.View();

        }


        [Authorize]
        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel viewModel)
        {

            if (this.ModelState.IsValid)
            {
                var username = this.User.Identity.Name;

                viewModel.User = this.dbcontext.Users.FirstOrDefault(x => x.UserName == username);

                this.ViewBag.Genders = new SelectList(this.genderService.GetGenderAsKVP());
                this.ViewBag.Categories = new SelectList(this.categoryService.GetCategoryAsKVP());

                return this.View(viewModel);
            }
            return this.BadRequest();
        }

    }
}
