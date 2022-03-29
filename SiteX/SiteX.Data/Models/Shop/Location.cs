using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Shop
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100),MinLength(3)]
        public string Name { get; set; }
        [Required,MaxLength(100),MinLength(10)]
        public string Address { get; set; }

    }
}
