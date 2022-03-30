using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteX.Data.Models.Shop
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required, MaxLength(400), MinLength(3)]
        public string Description { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public UserX User { get; set; }
        public bool IsAvalable { get; set; }
        [MaxLength(4)]
        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    }
}
