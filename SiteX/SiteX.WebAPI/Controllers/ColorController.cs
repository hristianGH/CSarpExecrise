using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels.ColorModels;
using System.Threading.Tasks;

namespace SiteX.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorService colorService;

        public ColorController(IColorService colorService)
        {
            this.colorService = colorService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var colors = this.colorService.GetColors();
            return this.Ok(colors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return this.Ok(new ColorViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ColorViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.colorService.CreateAsync(viewModel);
            return this.Ok(viewModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = this.colorService.GetColorById(id);

            return this.Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Color viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.colorService.EditColorAsync(viewModel);

            return this.Ok(viewModel);
        }
    }
}
