namespace SiteX.Data.Models.Blog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Identity;
    using SiteX.Data.Common.Models;

    public class Comment : BaseDeletableModel<Guid>
    {
        [MaxLength(250)]
        [MinLength(1)]
        [Required]
        public string Body { get; set; }

        public int UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
