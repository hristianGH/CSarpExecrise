namespace SiteX.Services.Data.BlogService.Interface
{
    using System.Collections.Generic;

    using System.Threading.Tasks;

    using SiteX.Data.Models.Blog;

    using SiteX.Web.ViewModels.BlogViewModels;

    public interface IPostService
    {
        public Task CreatePostAsync(PostViewModel viewModel);

        public Post GetPost();

        public int GetPostCount();

        public ICollection<PostOutViewModel> GetAllPostsAsOutModel();

        public ICollection<PostOutViewModel> ToPage(int page = 1, int itemsPerPage = 6);
    }
}
