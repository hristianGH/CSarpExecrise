using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IProductColorService
    {

        public Task CreatingProductColorAsync(ICollection<int> colors, Guid product);
    }
}
