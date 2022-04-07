﻿using SiteX.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Blog
{
    public class PostImage:BaseDeletableModel<Guid>
    {
 
        [Required]
        public string Path { get; set; }
        public Post Post { get; set; }
        public Guid ProductId { get; set; }

    }
}
