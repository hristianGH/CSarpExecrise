namespace SiteX.Services.Data.BlogService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Blog;
    using SiteX.Services.Data.BlogService.Interface;

    public class PostImageService : IPostImageService
    {
        private readonly IDeletableEntityRepository<PostImage> postImageRepo;

        public PostImageService(IDeletableEntityRepository<PostImage> postImageRepo)
        {
            this.postImageRepo = postImageRepo;
        }

        public ICollection<PostImage> GetPostImages(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<PostImage> GetImagesByPostId(int id)
        {
            return this.postImageRepo.AllAsNoTracking().Where(x => x.PostId == id).ToList();
        }
    }
}
