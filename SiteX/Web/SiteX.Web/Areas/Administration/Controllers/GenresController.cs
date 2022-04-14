using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Blog;
using SiteX.Services.Data.BlogService.Interface;
using SiteX.Web.ViewModels.BlogViewModels;
using System.Threading.Tasks;

namespace SiteX.Web.Areas.Administration.Controllers
{
    public class GenresController : AdministrationController
    {
        private readonly IGenreService genreService;

        public GenresController(IGenreService genreService)
        {
            this.genreService = genreService;
        }
        // GET: GenreController
        public ActionResult Index()
        {
            var genres =this.genreService.GetGenres();
            return View(genres);
        }

        // GET: GenreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenreController/Create
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenreViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.genreService.CreateAsync(viewModel);
            return this.Redirect("/");
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = this.genreService.GetGenreById(id);

            return View(viewModel);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Genre genre)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.genreService.EditAsync(genre);

            return this.Redirect("/");
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenreController/Delete/5
        [HttpPost]
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
