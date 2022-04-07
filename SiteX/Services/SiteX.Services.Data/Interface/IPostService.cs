using SiteX.Web.ViewModels.BlogViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.Interface
{
    public interface IPostService
    {
        public Task CreatePostAsync(PostViewModel viewModel);

        public Task CreatingPostGenre(ICollection<int> genres, int product);

    }
}
