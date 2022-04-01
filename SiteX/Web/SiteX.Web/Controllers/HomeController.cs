namespace SiteX.Web.Controllers
{
    using System.Diagnostics;

    using SiteX.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using SiteX.Data;
    using System.Linq;

    public class HomeController : BaseController

    {
        //TODO Make it repository
        private readonly ApplicationDbContext _dbContext;
        public HomeController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IActionResult Index(IndexViewModel viewModel)
        {
            var count = 0;

            ViewBag.Count = _dbContext.Users.Count();
            return this.View();
        }
        //TODO Make List of 5 articles to show on Home page
        //Service,View,Model
        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
