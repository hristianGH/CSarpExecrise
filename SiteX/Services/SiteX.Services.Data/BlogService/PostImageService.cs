using SiteX.Data.Models.Blog;
using SiteX.Services.Data.BlogService.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.BlogService
{
    public class PostImageService : IPostImageService
    {
        public ICollection<PostImage> GetPostImages(int id)
        {
            throw new NotImplementedException();
        }
    }
}
