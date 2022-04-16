namespace SiteX.Services.Data.ShopService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels.ColorModels;

    public class ColorService : IColorService
    {
        private readonly IRepository<Color> colorRepo;
        private readonly IDeletableEntityRepository<ProductColor> prodColorRepo;

        public ColorService(
            IRepository<Color> colorRepo,
            IDeletableEntityRepository<ProductColor> prodColorRepo)
        {
            this.colorRepo = colorRepo;
            this.prodColorRepo = prodColorRepo;
        }

        public async Task CreateAsync(ColorViewModel viewModel)
        {
            var color = new Color() { Name = viewModel.Name };
            await this.colorRepo.AddAsync(color);
            await this.colorRepo.SaveChangesAsync();
        }

        public async Task EditColorAsync(Color color)
        {
            var editColor = this.colorRepo.All().Where(x => x.Id == color.Id).FirstOrDefault();
            editColor.Name = color.Name;

            await this.colorRepo.SaveChangesAsync();
        }

        public Dictionary<string, string> GetColorAsKVP()
        {
            throw new NotImplementedException();
        }

        public Color GetColorById(int id)
        {
            return this.colorRepo.AllAsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Color> GetColors()
        {
            var colors = this.colorRepo.AllAsNoTracking().ToList();
            return colors;
        }

        public ICollection<Color> GetColorsByProductId(Guid id)
        {
            var productColors = this.prodColorRepo.AllAsNoTracking().Where(x => x.ProductId == id).ToList();
            List<Color> colors = new List<Color>();
            var all = this.colorRepo.AllAsNoTracking().ToList();
            foreach (var color in productColors)
            {
                var name = all.Where(x => x.Id == color.ColorId).Select(x => x.Name).ToString();
                colors.Add(new Color { Id = color.ColorId, Name = name });
            }

            return colors;
        }

        public int GetColorsCount()
        {
            return this.colorRepo.AllAsNoTracking().Count();
        }
    }
}
