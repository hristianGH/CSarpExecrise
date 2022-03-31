using Microsoft.AspNetCore.Mvc;

namespace SiteX.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
