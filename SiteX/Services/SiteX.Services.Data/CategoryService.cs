using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteX.Services.Data
{
    public class CategoryService : ICategoryToDictionary
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
    }
}
