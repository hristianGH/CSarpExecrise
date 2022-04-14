using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels.SizeModels;
using System.Threading.Tasks;

namespace SiteX.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SizeController : ControllerBase
    {


        private readonly ISizeService sizeService;

        public SizesController(ISizeService sizeService)
        {
            this.sizeService = sizeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var sizes = this.sizeService.GetSizes();
            return this.Ok(sizes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return this.Ok(new SizeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SizeViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.sizeService.CreateAsync(viewModel);
            return this.Ok(viewModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = this.sizeService.GetSizeById(id);

            return this.Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Size viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.sizeService.EditSizeAsync(viewModel);

            return this.Ok(viewModel);
        }
    }
}
