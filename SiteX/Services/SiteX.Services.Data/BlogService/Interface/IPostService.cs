using SiteX.Data.Models.Blog;
using SiteX.Web.ViewModels.BlogViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.BlogService.Interface
{
    public interface IPostService
    {
        public Task CreatePostAsync(PostViewModel viewModel);


        public Post GetPost();
        public int GetPostCount();

        public ICollection<PostOutViewModel> GetAllPostsAsOutModel();

        public ICollection<PostOutViewModel> ToPage(int page = 1, int itemsPerPage = 6);


    }
}
