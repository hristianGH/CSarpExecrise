namespace SiteX.Services.Data.BlogService.Interface
{
    using System.Collections.Generic;

    using SiteX.Data.Models.Blog;

    public interface IPostImageService
    {
        public ICollection<PostImage> GetPostImages(int id);

        public ICollection<PostImage> GetImagesByPostId(int id);
    }
}
