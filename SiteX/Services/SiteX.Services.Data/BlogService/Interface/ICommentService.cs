namespace SiteX.Services.Data.BlogService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Blog;
    using SiteX.Web.ViewModels.BlogViewModels;

    public interface ICommentService
    {
        public IEnumerable<Comment> GetComents();

        public Task Create(CommentViewModel comment);

        public Task AddCommentToPost(Post post);

        public ICollection<Comment> GetCommentsByPostId(int id);

        public bool IsInPostId(int commentId, int postId);
    }
}
