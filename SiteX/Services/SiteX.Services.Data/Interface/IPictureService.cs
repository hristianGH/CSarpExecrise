using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.Interface
{
    public interface IPictureService
    {
        public ICollection<ProductImage> GetImagesByProductId(Guid id);

    }
}
