using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    public interface IGenderService
    {
        Dictionary<string, string> GetGenderAsKVP();
        public IEnumerable<string> GetGenders();
    }
}
