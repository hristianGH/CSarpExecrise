using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Blog
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100),MinLength(10)]
        public string Title { get; set; }

        [Required,MaxLength(10_000),MinLength(100)]
        public string Body { get; set; }
        
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public Poster Poster { get; set; }
        [MaxLength(15)]
        public ICollection<PostImage> Images { get; set; } = new List<PostImage>();

    }
}
