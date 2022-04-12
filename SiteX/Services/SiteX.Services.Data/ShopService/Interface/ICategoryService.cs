namespace SiteX.Services.Data.ShopService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Shop;
    using SiteX.Web.ViewModels.ShopViewModels.CategoryModels;

    public interface ICategoryService
    {
        public Dictionary<string, string> GetCategoryAsKVP();

        public IEnumerable<string> GetCategoriesName();

        public IEnumerable<Category> GetCategories();

        public Category GetCategoryById(int id);

        public Task EditCategoryAsync(Category category);

        public Task EditAsync(CategoryEditViewModel category);

        public Task CreateAsync(CategoryViewModel viewModel);

        public ICollection<Category> GetCategoriesByProductId(Guid id);

        public int GetCategoryCount();
    }
}
