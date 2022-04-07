using SiteX.Data.Models.Blog;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.Interface
{
    public interface IGenreService
    {
        public Task CreateAsync(GenreViewModel viewModel);
        public IEnumerable<Genre> GetGenres();

    }
}
