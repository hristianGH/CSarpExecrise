using SiteX.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace SiteX.Data.Models.Shop
{
    public class Category:BaseModel<int>
    {
        
        [Required,MaxLength(100),MinLength(3)]
        public string Name { get; set; }

    }
}
