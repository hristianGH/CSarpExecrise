using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data;
using SiteX.Services.Data;
using SiteX.Web.ViewModels.ShopViewModels;
using System.Linq;

namespace SiteX.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IGenderService genderService;


        //TODO IdeletableEntityRepository
        public ShopController(ApplicationDbContext dbContext, IGenderService genderService)
        {
            dbcontext = dbContext;
            this.genderService = genderService;
        }


        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel() { };
            return View();
        }


        [Authorize]
        public IActionResult CreateProduct(ProductViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                var username = this.User.Identity.Name;

                viewModel.User = dbcontext.Users.FirstOrDefault(x => x.UserName == username);

                viewModel.Genders = genderService.GetGenderAsKVP();

                return View(viewModel);
            }
            return this.BadRequest();
        }
    }
}
