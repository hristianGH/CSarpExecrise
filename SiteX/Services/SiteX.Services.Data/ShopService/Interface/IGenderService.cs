using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IGenderService
    {
        Dictionary<string, string> GetGenderAsKVP();
        public IEnumerable<string> GetGenders();
    }
}
