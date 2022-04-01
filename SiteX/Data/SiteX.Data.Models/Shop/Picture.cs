namespace SiteX.Data.Models.Shop
{
    using System.ComponentModel.DataAnnotations;

    using SiteX.Data.Common.Models;

    public class Picture : BaseModel<int>
    {
     
        [Required]
        public string Path { get; set; }
    }
}
