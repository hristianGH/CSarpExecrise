using Microsoft.AspNetCore.Identity;
using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Data.Models.Blog
{
    public class Comment:BaseDeletableModel<Guid>
    {
        [MaxLength(250),MinLength(1),Required]
        public string Body { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
