namespace SiteX.Services.Data.BlogService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Blog;
    using SiteX.Services.Data.BlogService.Interface;
    using SiteX.Web.ViewModels.BlogViewModels;

    public class CommentService : ICommentService
    {
        private readonly IDeletableEntityRepository<Comment> commentRepo;

        public CommentService(IDeletableEntityRepository<Comment> commentRepo)
        {
            this.commentRepo = commentRepo;
        }
        public Task AddCommentToPost(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task Create(CommentViewModel viewModel)
        {
            if (viewModel.ParentId == 0)
            {
                viewModel.ParentId = null;
            }
            Comment comment = new Comment()
            {
                Body = viewModel.Body,
                Parent = viewModel.Parent,
                Post = viewModel.Post,
                User = viewModel.User,
                ParentId = viewModel.ParentId,
                PostId = viewModel.PostId,
                UserId = viewModel.User.Id,
            };
            await this.commentRepo.AddAsync(comment);
            await this.commentRepo.SaveChangesAsync();
        }

        public IEnumerable<Comment> GetComents()
        {
            return this.commentRepo.AllAsNoTracking().ToList();
        }

        public ICollection<Comment> GetCommentsByPostId(int id)
        {
            return this.commentRepo.AllAsNoTracking().Where(x => x.Post.Id == id).ToList();
        }

        public bool IsInPostId(int commentId, int postId)
        {
            var commentPostId = this.commentRepo.All().Where(x => x.Id == commentId)
                .Select(x => x.PostId).FirstOrDefault();
            return commentPostId == postId;
        }
    }
}
