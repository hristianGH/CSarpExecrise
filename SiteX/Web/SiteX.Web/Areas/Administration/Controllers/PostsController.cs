using Microsoft.AspNetCore.Mvc;
using SiteX.Services.Data.BlogService.Interface;
using SiteX.Web.ViewModels.BlogViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SiteX.Web.Areas.Administration.Controllers
{
    public class PostsController : AdministrationController
    {
        private readonly IPostService postService;
        private readonly IGenreService genreService;

        public PostsController(IPostService postService,
            IGenreService genreService)
        {
            this.postService = postService;
            this.genreService = genreService;
        }

        public IActionResult Index()
        {
            var posts = this.postService.GetPosts();
            return this.View(posts);
        }


        public IActionResult Edit(int id)
        {
            var viewModel = this.postService.GetEditPostById(id);

            if (viewModel.PostImages.Count() == 0)
            {
                viewModel.PostImages.Add(string.Empty);
            }

            viewModel.GenresToList = this.genreService.GetGenres();

            this.ViewBag.ProductId = viewModel.Id;

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostEditViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.postService.EditPostAsync(viewModel);

            return this.Redirect("/");
        }
    }
}
