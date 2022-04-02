using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    public interface ICategoryService
    {
      public  Dictionary<string, string> GetCategoryAsKVP();
        public IEnumerable<string> GetCategoriesName();
  
        public IEnumerable<Category> GetCategories();

    }
}
