using SiteX.Data.Models.Shop;
using SiteX.Web.ViewModels.ShopViewModels;
using SiteX.Web.ViewModels.ShopViewModels.ColorModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService.Interface
{
    public interface IColorService
    {
        Dictionary<string, string> GetColorAsKVP();
        public IEnumerable<Color> GetColors();
        public ICollection<Color> GetColorsByProductId(Guid id);
        public int GetColorsCount();
        public  Task CreateAsync(ColorViewModel viewModel);


    }
}
