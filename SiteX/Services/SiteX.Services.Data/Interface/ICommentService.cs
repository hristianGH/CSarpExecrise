using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.Interface
{
    internal interface ICommentService
    {
        public IEnumerable<Comment> GetComents();
        public Task AddCommentToPost(Post post);

    }
}
