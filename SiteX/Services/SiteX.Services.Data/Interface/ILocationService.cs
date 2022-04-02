using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    public interface ILocationService
    {
        Dictionary<string, string> GetLocationAsKVP();
        public IEnumerable<string> GetLocations();

        //ToDO MAKE I CATEGORY,IGENDER,ILOCATION,IPICTURES SERVICES ONE MAIN KEYVALUEPAIR SERVICE INTERFACE
    }
}
