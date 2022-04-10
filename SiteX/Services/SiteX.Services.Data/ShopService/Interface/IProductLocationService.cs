using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IProductLocationService
    {

        public Task CreatingProductLocationAsync(ICollection<int> locations, Guid product);



        public Task HardDeleteProductLocationByIdAsync(Guid productId);



        public ICollection<Location> GetLocationsByProductId(Guid id);


    }
}
