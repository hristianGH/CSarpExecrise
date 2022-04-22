namespace SiteX.Services.Data.ShopService
{
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

        public  IEnumerable<Category> GetCategories()
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
