using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Services.Data.ArticleService.Interface;

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
            return View();
        }

        // POST: ArticlesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ArticlesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArticlesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
