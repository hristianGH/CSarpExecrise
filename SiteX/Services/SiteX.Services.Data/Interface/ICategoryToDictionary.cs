using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    public interface ICategoryToDictionary
    {
      public  Dictionary<string, string> GetCategoryAsKVP();
    }
}
