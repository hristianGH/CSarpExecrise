namespace SiteX.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SiteX.Services.Data.ArticleService.Interface;
    using SiteX.Web.ViewModels.ArticleViewModels;
    using SiteX.Web.ViewModels.BlogViewModels;

    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public IActionResult Index()
        {
            var articles = this.articleService.GetArticles();
            if (articles != null)
            {

                return this.View(articles);
            }
            else
            {
                return this.NotFound();
            }
        }

        public IActionResult All(int page = 1)
        {

            AllArticleViewModel articleViewModel = new AllArticleViewModel() { Articles = this.articleService.ToPage(page, 20), PageNumber = page, ItemsPerPage = 20 };

            articleViewModel.ItemsCount = this.articleService.GetArticlesCount();

            return this.View(articleViewModel);
        }
        public IActionResult ById(int id)
        {
            var article = this.articleService.GetArticleById(id);
            return this.View(article);
        }

    }
}
