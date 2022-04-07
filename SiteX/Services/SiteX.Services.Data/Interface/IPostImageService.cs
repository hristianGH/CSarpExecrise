using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    internal interface IPostImageService
    {
        public ICollection<PostImage> GetPostImages(int id);
    }
}
