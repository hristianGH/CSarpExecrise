namespace SiteX.Web.ViewModels.ShopViewModels.LocationModels
{
    using System.ComponentModel.DataAnnotations;

    public class LocationEditViewModel
    {
        [Display(Name = "Select Address")]
        public int OldId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        [Display(Name = "New Address")]
        public string NewAddress { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        [Display(Name = "New Name of building")]
        public string NewName { get; set; }
    }
}
