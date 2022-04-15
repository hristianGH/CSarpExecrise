using SiteX.Data.Models;
using SiteX.Data.Models.Blog;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiteX.Web.ViewModels.BlogViewModels
{
    public class CommentViewModel
    {
        public Post Post { get; set; }

        public int PostId { get; set; }

        [Required]
        [MaxLength(350)]
        [MinLength(3)]
        public string Body { get; set; }

        public ApplicationUser User { get; set; }

        public Comment Parent { get; set; }

        public int? ParentId { get; set; }
    }
}
