using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Article;
using SiteX.Services.Data.ArticleService.Interface;
using System.Threading.Tasks;

namespace SiteX.Web.Areas.Administration.Controllers
{
    public class ArticlesController : AdministrationController
    {
        private readonly IArticleService articleService;

        public ArticlesController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        // GET: ArticlesController
        public ActionResult Index()
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

        // GET: ArticlesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArticlesController/Create
        public ActionResult Create()
        {
            var article = new Article();
            return View(article);
        }

        // POST: ArticlesController/Create
        [HttpPost]
        public async Task<ActionResult> Create(Article article)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.articleService.CreateArticleAsync(article);
            return this.RedirectToAction(nameof(this.Index));
        }

        // GET: ArticlesController/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = this.articleService.GetArticleById(id);
            return this.View(edit);
        }

        // POST: ArticlesController/Edit/5
        [HttpPost]
        public ActionResult Edit(Article edit)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
            this.articleService.EditArticleAsync(edit);
            return RedirectToAction(nameof(Index));
        }

        // GET: ArticlesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArticlesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
