namespace SiteX.Services.Data.BlogService
{
    using System;
    using System.Collections.Generic;

    using SiteX.Data.Models.Blog;
    using SiteX.Services.Data.BlogService.Interface;

    public class PostImageService : IPostImageService
    {
        public ICollection<PostImage> GetPostImages(int id)
        {
            throw new NotImplementedException();
        }
    }
}
