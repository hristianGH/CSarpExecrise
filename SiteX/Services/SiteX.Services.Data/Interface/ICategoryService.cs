using SiteX.Data.Models.Shop;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.Interface
{
    public interface ICategoryService
    {
        public Dictionary<string, string> GetCategoryAsKVP();
        public IEnumerable<string> GetCategoriesName();

        public IEnumerable<Category> GetCategories();
        public Task EditAsync(CategoryEditViewModel category);
        public Task CreateAsync(CategoryViewModel viewModel);



    }
}
