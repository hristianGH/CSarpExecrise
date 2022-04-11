using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.BlogService.Interface
{
    public interface IPostGenreService
    {

        public Task CreatingPostGenreAsync(ICollection<int> genres, int post);

        public Task HardDeletePostGenreByIdAsync(int postid);



    }
}
