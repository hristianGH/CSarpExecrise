namespace SiteX.Web.ViewModels.BlogViewModels
{
    using System.Collections.Generic;
    using SiteX.Data.Models.Blog;

    public class CommentEditViewModel
    {
        public PostOutViewModel Post { get; set; }

        public int PostId { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
