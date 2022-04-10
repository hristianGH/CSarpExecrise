namespace SiteX.Web.Controllers
{
    using System.Diagnostics;

    using SiteX.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using SiteX.Data;
    using System.Linq;
    using SiteX.Web.ViewModels.ShopViewModels;
    using SiteX.Services.Data;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Data.ShopService.Interface;

    public class HomeController : BaseController
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService )
        {
            this.productService = productService;
        }
        public IActionResult Index(int page)
        {
            productService.FilterByCategoryId(2);
            return this.View();

        }
        //TODO Make List of 5 articles to show on Home page
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
