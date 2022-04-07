using SiteX.Data.Models;
using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.BlogViewModels
{
    public class PostViewModel
    {

        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Title { get; set; }

        [Required]
        [MaxLength(10_000)]
        [MinLength(10)]
        public string Body { get; set; }

        public ApplicationUser User { get; set; }

       

        [MaxLength(4)]
        [Display(Name = "Picture Url")]
        public virtual ICollection<string> PostImages { get; set; } = new List<string>();

        [Display(Name = "Genres")]
        [MaxLength(2)]
        public ICollection<int> PostGenres { get; set; } = new List<int>();


    }
}
