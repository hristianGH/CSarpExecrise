using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IProductSizeService
    {
        public Task CreatingProductSizeAsync(ICollection<int> sizes, Guid product);
        
    }
}
