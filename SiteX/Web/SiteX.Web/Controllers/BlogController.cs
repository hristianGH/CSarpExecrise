namespace SiteX.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SiteX.Data.Models;
    using SiteX.Data.Models.Blog;
    using SiteX.Services.Data.BlogService.Interface;
    using SiteX.Web.ViewModels.BlogViewModels;

    public class BlogController : Controller
    {
        private readonly IGenreService genreService;
        private readonly IPostService postService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPostImageService postImageService;

        public BlogController(
            IGenreService genreService,
            IPostService postService,
            UserManager<ApplicationUser> userManager,
            IPostImageService postImageService)
        {
            this.genreService = genreService;
            this.postService = postService;
            this.userManager = userManager;
            this.postImageService = postImageService;
        }

        public IActionResult Index()
        {
            var post = this.postService.GetPost();
            return this.View(post);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreateGenre()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateGenre(GenreViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.genreService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult CreatePost()
        {
            this.ViewBag.Genres = new SelectList(this.genreService.GetGenres(), "Id", "Name");
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreatePost(PostViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            viewModel.User = await this.userManager.GetUserAsync(this.User);
            await this.postService.CreatePostAsync(viewModel);

            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            PostAllViewModel postViewModel = new PostAllViewModel() { Posts = this.postService.ToPage(id, 6), PageNumber = id, ItemsPerPage = 8 };

            postViewModel.ItemsCount = this.postService.GetPostCount();

            return this.View(postViewModel);
        }

        public IActionResult ById(int id)
        {
            var post = this.postService.GetOutputPostById(id);
            this.ViewBag.ImageOne = this.postImageService.GetImagesByPostId(id).Select(x => x.Path).FirstOrDefault();
            this.ViewBag.Images = this.postImageService.GetImagesByPostId(id).Select(x => x.Path).Skip(1);

            return this.View(post);
        }
    }
}
