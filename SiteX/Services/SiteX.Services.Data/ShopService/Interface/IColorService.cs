using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IColorService
    {
        Dictionary<string, string> GetColorAsKVP();
        public IEnumerable<Color> GetColors();
    }
}
