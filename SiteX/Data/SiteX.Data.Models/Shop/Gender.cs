
namespace SiteX.Data.Models.Shop
{
    using System.ComponentModel.DataAnnotations;

    public class Gender
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }
    }
}
