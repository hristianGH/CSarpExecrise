using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    public interface IGenderToDictionary
    {
        Dictionary<string, string> GetGenderAsKVP();
    }
}
