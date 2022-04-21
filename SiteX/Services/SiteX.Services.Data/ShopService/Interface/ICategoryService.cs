namespace SiteX.Services.Data.ShopService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Shop;
    using SiteX.Web.ViewModels.ShopViewModels.CategoryModels;

    public interface ICategoryService
    {
        public IEnumerable<Category> GetCategories();

        public Category GetCategoryById(int id);

        public Task EditCategoryAsync(Category category);

        public Task CreateAsync(CategoryViewModel viewModel);

        public int GetCategoryCount();
    }
}
