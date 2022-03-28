using Microsoft.AspNetCore.Mvc;

namespace SiteX.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
