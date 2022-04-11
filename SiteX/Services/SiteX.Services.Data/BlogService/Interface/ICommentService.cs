namespace SiteX.Services.Data.BlogService.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Blog;

    internal interface ICommentService
    {
        public IEnumerable<Comment> GetComents();

        public Task AddCommentToPost(Post post);
    }
}
