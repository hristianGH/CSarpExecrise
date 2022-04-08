using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteX.Data.Models;
using SiteX.Services.Data.BlogService.Interface;
using SiteX.Web.ViewModels.BlogViewModels;
using System.Threading.Tasks;

namespace SiteX.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IGenreService genreService;
        private readonly IPostService postService;
        private readonly UserManager<ApplicationUser> userManager;

        public BlogController(IGenreService genreService,
            IPostService postService,
            UserManager<ApplicationUser> userManager
             )
        {
            this.genreService = genreService;
            this.postService = postService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }



        [Authorize]
        public IActionResult CreateGenre()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task< IActionResult> CreateGenre(GenreViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
           await this.genreService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        [Authorize]
        public async Task<IActionResult> CreatePost()
        {
            this.ViewBag.Genres = new SelectList(this.genreService.GetGenres(), "Id", "Name");
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreatePost(PostViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            viewModel.User = await this.userManager.GetUserAsync(this.User);
           await this.postService.CreatePostAsync(viewModel);

            return this.Redirect("/");
        }

    }
}
