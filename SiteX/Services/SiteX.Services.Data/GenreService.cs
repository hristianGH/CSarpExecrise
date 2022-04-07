using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Blog;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genreRepo;

        public GenreService(IRepository<Genre> genreRepo)
        {
            this.genreRepo = genreRepo;
        }
        public async Task CreateAsync(GenreViewModel viewModel)
        {
            var genre = new Genre() { Name = viewModel.Name };
            await this.genreRepo.AddAsync(genre);
            await this.genreRepo.SaveChangesAsync();
        }

        public IEnumerable<Genre> GetGenres()
        {
            var genres = this.genreRepo.AllAsNoTracking().ToList();
            return genres;
        }
    }
}
