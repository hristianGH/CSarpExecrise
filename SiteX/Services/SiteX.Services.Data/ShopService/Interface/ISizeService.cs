using SiteX.Data.Models.Shop;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface ISizeService
    {
        Dictionary<string, string> GetSizeAsKVP();
        public IEnumerable<Size> GetSizes();
        public ICollection<Size> GetSizesByProductId(Guid id);
        public int GetSizesCount();

        // Color view Model uses Name only like SIze so im gonna save some code
        public Task CreateAsync(SizeViewModel viewModel);



    }
}
