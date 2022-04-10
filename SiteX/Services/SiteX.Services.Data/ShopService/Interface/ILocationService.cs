using SiteX.Data.Models.Shop;
using SiteX.Web.ViewModels.ShopViewModels;
using SiteX.Web.ViewModels.ShopViewModels.LocationModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface ILocationService
    {
        Dictionary<string, string> GetLocationAsKVP();
        public IEnumerable<Location> GetLocations();
        public Task CreateAsync(LocationViewModel viewModel);
        public Task EditAsync(LocationEditViewModel location);
        public ICollection<Location> GetLocationsByProductId(Guid id);



        //ToDO MAKE I CATEGORY,IGENDER,ILOCATION,IPICTURES SERVICES ONE MAIN KEYVALUEPAIR SERVICE INTERFACE
    }
}
