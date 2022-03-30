using SiteX.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Shop
{
    public class Picture:BaseModel<int>
    {
     
        [Required]
        public string Path { get; set; }
    }
}
