namespace SiteX.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using SiteX.Data.Models;
    using SiteX.Services.Data.BlogService.Interface;
    using SiteX.Web.ViewModels.BlogViewModels;

    public class BlogController : Controller
    {
        private readonly IGenreService genreService;
        private readonly IPostService postService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPostImageService postImageService;
        private readonly IBlogListService toListService;
        private readonly ICommentService commentService;

        public BlogController(
            IGenreService genreService,
            IPostService postService,
            UserManager<ApplicationUser> userManager,
            IPostImageService postImageService,
            IBlogListService toListService,
            ICommentService commentService)
        {
            this.genreService = genreService;
            this.postService = postService;
            this.userManager = userManager;
            this.postImageService = postImageService;
            this.toListService = toListService;
            this.commentService = commentService;
        }

        public IActionResult Index()
        {
            var post = this.postService.GetPost();
            return this.View(post);
        }

        public IActionResult All(int id = 1)
        {
            PostAllViewModel postViewModel = new PostAllViewModel() { Posts = this.postService.ToPage(id, 6), PageNumber = id, ItemsPerPage = 8 };

            postViewModel.ItemsCount = this.postService.GetPostCount();
            postViewModel.ToSelectList = this.toListService.ToSelectedList();

            return this.View(postViewModel);
        }

        public IActionResult ById(int id)
        {
            var post = this.postService.GetOutputPostById(id);
            this.ViewBag.ImageOne = this.postImageService.GetImagesByPostId(id).Select(x => x.Path).FirstOrDefault();
            this.ViewBag.Images = this.postImageService.GetImagesByPostId(id).Select(x => x.Path).Skip(1);
            post.Comments = this.commentService.GetCommentsByPostId(id);
            return this.View(post);
        }

        public IActionResult SearchByGenre(int id = 1)
        {
            PostAllViewModel postViewModel = new PostAllViewModel()
            {
                Posts = this.postService.FilterByGenreId(id),
            };
            postViewModel.ItemsCount = this.postService.GetPostCount();
            postViewModel.ToSelectList = this.toListService.ToSelectedList();

            if (postViewModel != null)
            {
                return this.View("All", postViewModel);
            }

            return this.NotFound();
        }
    }
}
