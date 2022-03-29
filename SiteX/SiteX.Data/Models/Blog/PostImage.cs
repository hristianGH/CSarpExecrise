using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Blog
{
    public class PostImage
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Path { get; set; }
    }
}
