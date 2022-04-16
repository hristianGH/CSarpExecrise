namespace SiteX.Web.ViewModels.BlogViewModels
{
    using SiteX.Data.Models.Blog;

    using System.Collections.Generic;

    public class CommentEditViewModel
    {
        public PostOutViewModel Post { get; set; }

        public int PostId { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
