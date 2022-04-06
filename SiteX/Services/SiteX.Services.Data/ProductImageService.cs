using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteX.Services.Data
{
    public class ProductImageService : IPictureService
    {
        private readonly IRepository<ProductImage> imageRepo;

        public ProductImageService(IRepository<ProductImage> imageRepo)
        {
            this.imageRepo = imageRepo;
        }
        public ICollection<ProductImage> GetImagesByProductId(Guid id)
        {
           return imageRepo.AllAsNoTracking().Where(x => x.Product.Id == id).ToList();

        }
    }
}
