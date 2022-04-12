namespace SiteX.Services.Data.ShopService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels.CategoryModels;

    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> categoryRepository;
        private readonly IRepository<ProductCategory> productCategoryRepository;

        public CategoryService(
            IRepository<Category> categoryRepository,
            IRepository<ProductCategory> productCategoryRepository)
        {
            this.categoryRepository = categoryRepository;
            this.productCategoryRepository = productCategoryRepository;
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
            var category = new Category() { Name = viewModel.Name };
            await this.categoryRepository.AddAsync(category);
            await this.categoryRepository.SaveChangesAsync();
        }

        public async Task EditAsync(CategoryEditViewModel category)
        {
            var categoryEdit = this.categoryRepository.All().FirstOrDefault(x => x.Id == category.OldId);
            categoryEdit.Name = category.NewName;
            await this.categoryRepository.SaveChangesAsync();
        }

        public ICollection<Category> GetCategoriesByProductId(Guid id)
        {
            var productCategories = this.productCategoryRepository.AllAsNoTracking().Where(x => x.ProductId == id).ToList();
            List<Category> categories = new List<Category>();
            var all = this.categoryRepository.AllAsNoTracking().ToList();
            foreach (var category in productCategories)
            {
                var name = all.Where(x => x.Id == category.CategoryId).Select(x => x.Name).ToString();
                categories.Add(new Category { Id = category.CategoryId, Name = name });
            }

            return categories;
        }

        public int GetCategoryCount()
        {
            return this.categoryRepository.AllAsNoTracking().Count();
        }

        public Category GetCategoryById(int id)
        {
            return this.categoryRepository.All().Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task EditCategoryAsync(Category category)
        {
            var categoryEdit = this.categoryRepository.All().FirstOrDefault(x => x.Id == category.Id);
            categoryEdit.Name = category.Name;
            await this.categoryRepository.SaveChangesAsync();
        }
    }
}
