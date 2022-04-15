namespace SiteX.Web.ViewModels.BlogViewModels
{
    using System;
    using System.Collections.Generic;

    using SiteX.Data.Models;
    using SiteX.Data.Models.Blog;

    public class PostOutViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public ApplicationUser Poster { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime Date { get; set; }

        public string PreviewImage { get; set; }

        public string PreviewBody { get; set; }

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        public ICollection<PostImage> PostImages { get; set; } = new List<PostImage>();
    }
}
