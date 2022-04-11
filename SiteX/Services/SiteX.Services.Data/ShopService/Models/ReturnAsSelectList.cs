namespace SiteX.Services.Data.ShopService.Models
{
    using System.Collections.Generic;

    using SiteX.Data.Models.Shop;

    public class ReturnAsSelectList
    {
        public IEnumerable<string> Genders { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Location> Locations { get; set; }

        public IEnumerable<Size> Sizes { get; set; }

        public IEnumerable<Color> Colors { get; set; }
    }
}
