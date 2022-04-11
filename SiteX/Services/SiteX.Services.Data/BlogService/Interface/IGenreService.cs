namespace SiteX.Services.Data.BlogService.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Blog;
    using SiteX.Web.ViewModels.BlogViewModels;

    public interface IGenreService
    {
        public Task CreateAsync(GenreViewModel viewModel);

        public IEnumerable<Genre> GetGenres();

        public ICollection<Genre> GetGenresByPostId(int id);
    }
}
