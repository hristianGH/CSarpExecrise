﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteX.Data;
using SiteX.Data.Models;
using SiteX.Services.Data;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SiteX.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IGenderService genderService;
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly ILocationService locationService;
        private readonly UserManager<ApplicationUser> userManager;



        //TODO IdeletableEntityRepository
        public ShopController(ApplicationDbContext dbContext,
            IGenderService genderService,
            ICategoryService categoryService,
            IProductService productService,
            ILocationService locationService,
            UserManager<ApplicationUser> userManager)
        {
            dbcontext = dbContext;
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.productService = productService;
            this.locationService = locationService;
            this.userManager = userManager;
        }


        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel() { };
            return View();
        }

        [Authorize]
        public async Task<IActionResult> CreateProduct()
        {
            this.ViewBag.Genders = new SelectList(this.genderService.GetGenders());
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations());

            return this.View();

        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel viewModel)
        {

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            viewModel.User = await this.userManager.GetUserAsync(this.User);

            this.ViewBag.Genders = new SelectList(this.genderService.GetGenderAsKVP());
            this.ViewBag.Categories = new SelectList(this.categoryService.GetCategories(), "Id", "Name");
            this.ViewBag.Locations = new SelectList(this.locationService.GetLocations());

            await this.productService.CreateAsync(viewModel);
            return this.Redirect("/");
        }
        [Authorize]
        public async Task<IActionResult> CreateCategory()
        {

            return this.View();

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryViewModel viewModel)
        {

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            await this.categoryService.CreateAsync(viewModel);
            return this.Redirect("/");

        }

        [Authorize]
        public async Task<IActionResult> CreateLocation()
        {

            return this.View();

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateLocation(LocationViewModel viewModel)
        {

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            await this.locationService.CreateAsync(viewModel);
            return this.Redirect("/");

        }

        
        public async Task<IActionResult> All(int page)
        {
            ProductListViewModel productViewModel=new ProductListViewModel() {Products=productService.ToList(1),Page=1};

            return this.View(productViewModel);

        }
    }
}
