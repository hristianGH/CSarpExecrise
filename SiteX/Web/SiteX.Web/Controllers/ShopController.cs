using Microsoft.AspNetCore.Mvc;
using SiteX.Data;
using SiteX.Web.ViewModels.ShopViewModels;

namespace SiteX.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        public ShopController(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel() { };
            return View();
        }
    }
}
