namespace SiteX.Services.Data.BlogService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Blog;
    using SiteX.Services.Data.BlogService.Interface;
    using SiteX.Web.ViewModels.BlogViewModels;

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

        public ICollection<Genre> GetGenresByPostId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
