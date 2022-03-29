using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Shop
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
    }
}
