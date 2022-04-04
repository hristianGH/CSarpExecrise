using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> categoryRepository;

        public CategoryService(IRepository<Category> repository)
        {
            this.categoryRepository = repository;
        }
        public Dictionary<string, string> GetCategoryAsKVP()
        {
            var dictionary = this.categoryRepository.AllAsNoTracking().Select(x => new { x.Id, x.Name }).ToDictionary(x => x.Id.ToString(), x => x.Name);
            return dictionary;

        }
        public IEnumerable<string> GetCategoriesName()
        {
            var category = this.categoryRepository.AllAsNoTracking().Select(x => x.Name).ToArray();
            return category;
        }
        public IEnumerable<Category> GetCategories()
        {
            var category = this.categoryRepository.AllAsNoTracking().ToArray();
            return category;
        }

        public async Task CreateAsync(CategoryViewModel viewModel)
        {
            var category = new Category() {Name = viewModel.Name};
           await categoryRepository.AddAsync(category);
            await this.categoryRepository.SaveChangesAsync();

        }
        
    }
}
