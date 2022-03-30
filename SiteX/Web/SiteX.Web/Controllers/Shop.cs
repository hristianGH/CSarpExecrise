using Microsoft.AspNetCore.Mvc;

namespace SiteX.Web.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
