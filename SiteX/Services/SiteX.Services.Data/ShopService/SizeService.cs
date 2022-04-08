using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteX.Services.Data.ShopService
{
    public class SizeService : ISizeService
    {
        private readonly IRepository<Size> sizeRepo;

        public SizeService(IRepository<Size> sizeRepo)
        {
            this.sizeRepo = sizeRepo;
        }
        public Dictionary<string, string> GetSizeAsKVP()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Size> GetSizes()
        {
            var sizes = this.sizeRepo.AllAsNoTracking().ToList();
            return sizes;
        }

    }
}
