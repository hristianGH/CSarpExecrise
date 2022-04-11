namespace SiteX.Services.Data.BlogService.Interface
{
    using System.Collections.Generic;

    using SiteX.Data.Models.Blog;

    internal interface IPostImageService
    {
        public ICollection<PostImage> GetPostImages(int id);
    }
}
