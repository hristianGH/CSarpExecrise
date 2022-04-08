using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteX.Services.Data.ShopService
{
    public class ColorService : IColorService
    {
        private readonly IRepository<Color> colorRepo;

        public ColorService(IRepository<Color> colorRepo)
        {
            this.colorRepo = colorRepo;
        }
        public Dictionary<string, string> GetColorAsKVP()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Color> GetColors()
        {
            var colors = this.colorRepo.AllAsNoTracking().ToList();
            return colors ;
        }
    }
}
