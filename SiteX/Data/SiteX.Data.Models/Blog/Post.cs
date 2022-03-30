using Microsoft.AspNetCore.Identity;
using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteX.Data.Models.Blog
{
    public class Post :BaseDeletableModel<int>
    {
  

        [Required,MaxLength(100),MinLength(10)]
        public string Title { get; set; }

        [Required,MaxLength(10_000),MinLength(10)]
        public string Body { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [MaxLength(15)]
        public virtual ICollection<PostImage> Images { get; set; } = new List<PostImage>();

    }
}
