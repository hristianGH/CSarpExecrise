using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IProductCategoryService
    {

        public Task CreatingProductCategoryAsync(ICollection<int> categories, Guid product);
        public  Task HardDeleteProductCategoriesByIdAsync(Guid productId);
        public ICollection<Category> GetCategoriesByProductId(Guid id);
    }
}
