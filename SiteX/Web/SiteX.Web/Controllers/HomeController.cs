namespace SiteX.Web.Controllers
{
    using System.Diagnostics;

    using SiteX.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using SiteX.Data;
    using System.Linq;
    using SiteX.Web.ViewModels.ShopViewModels;
    using SiteX.Services.Data;
    using SiteX.Services.Data.Interface;
    using SiteX.Data.Models.Shop;

    public class HomeController : BaseController

    {
        //TODO Make it repository
        private readonly ApplicationDbContext _dbContext;
        private readonly IProductService productService;

        public HomeController(ApplicationDbContext dbContext,IProductService productService)
        {
            this._dbContext = dbContext;
            this.productService = productService;
        }
        public IActionResult Index(int page)
        {

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
