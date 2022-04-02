using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data
{
    public interface IGenderToDictionary
    {
        Dictionary<string, string> GetGenderAsKVP();
    }
}
