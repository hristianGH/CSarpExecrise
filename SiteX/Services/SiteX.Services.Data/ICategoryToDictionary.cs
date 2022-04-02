using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data
{
    public interface ICategoryToDictionary
    {
      public  Dictionary<string, string> GetCategoryAsKVP();
    }
}
