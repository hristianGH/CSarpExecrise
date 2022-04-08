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
        private readonly IDeletableEntityRepository<ProductSize> prodSizeRepo;

        public SizeService(IRepository<Size> sizeRepo,
            IDeletableEntityRepository<ProductSize> prodSizeRepo)
        {
            this.sizeRepo = sizeRepo;
            this.prodSizeRepo = prodSizeRepo;
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

        public ICollection<Size> GetSizesByProductId(Guid id)
        {
            var productSizes = prodSizeRepo.AllAsNoTracking().Where(x => x.ProductId == id).ToList();
            List<Size> sizes = new List<Size>();
            var all = sizeRepo.AllAsNoTracking().ToList();
            foreach (var size in productSizes)
            {
                var name = all.Where(x => x.Id == size.SizeId).Select(x => x.Name).ToString();
                sizes.Add(new Size { Id = size.SizeId, Name = name });
            }
            return sizes;

        }

        public int GetSizesCount()
        {
            return sizeRepo.AllAsNoTracking().Count();
        }
    }
}
