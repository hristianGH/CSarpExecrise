using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class ToSelectList
    {
        public IEnumerable<string> GendersToList { get; set; }
        public IEnumerable<Category> CategoriesToList { get; set; }
        public IEnumerable<Location> LocationsToList { get; set; }
        public IEnumerable<Size> SizesToList { get; set; }
        public IEnumerable<Color> ColorsToList { get; set; }

    }
}
