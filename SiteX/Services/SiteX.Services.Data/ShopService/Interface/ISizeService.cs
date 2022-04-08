using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface ISizeService
    {
        Dictionary<string, string> GetSizeAsKVP();
        public IEnumerable<Size> GetSizes();
        public ICollection<Size> GetSizesByProductId(Guid id);
        public int GetSizesCount();


    }
}
