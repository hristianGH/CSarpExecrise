using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Shop
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100),MinLength(3)]
        public string Name { get; set; }

    }
}
