namespace SiteX.Services.Data.ShopService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Shop;
    using SiteX.Web.ViewModels.ShopViewModels.ColorModels;

    public interface IColorService
    {
        Dictionary<string, string> GetColorAsKVP();

        public IEnumerable<Color> GetColors();

        public Color GetColorById(int id);

        public Task EditColorAsync(Color color);

        public ICollection<Color> GetColorsByProductId(Guid id);

        public int GetColorsCount();

        public Task CreateAsync(ColorViewModel viewModel);
    }
}
