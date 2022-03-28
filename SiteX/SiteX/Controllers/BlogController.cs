using Microsoft.AspNetCore.Mvc;

namespace SiteX.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
