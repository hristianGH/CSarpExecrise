using SiteX.Data.Models;
using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;

namespace SiteX.Web.ViewModels.BlogViewModels
{
    public class PostOutViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public ApplicationUser User { get; set; }
        public DateTime Date { get; set; }

        public string PreviewImage { get; set; }
        public ICollection<PostGenre> PostGenres { get; set; } = new List<PostGenre>();
        public ICollection<PostImage> PostImages { get; set; }=new List<PostImage>();


    }
}
