namespace SiteX.Data.Models.Blog
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using SiteX.Data.Common.Models;

    public class Comment : BaseDeletableModel<Guid>
    {
        [MaxLength(250)]
        [MinLength(1)]
        [Required]
        public string Body { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }
    }
}
