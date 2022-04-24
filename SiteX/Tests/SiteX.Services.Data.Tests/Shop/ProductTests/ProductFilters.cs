using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Mapping;
using SiteX.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SiteX.Services.Data.Tests.Shop.ProductTests
{
    public class ProductFilters
    {
        [Fact]
        public async Task ProductFilterByCategorySholdFilter()
        {
            var list = new List<Product>();
            if (AutoMapperConfig.MapperInstance == null)
            {
                AutoMapperConfig.RegisterMappings(typeof(IndexViewModel).GetTypeInfo().Assembly);
            }

            // var mockProductRepo = new Mock<IDeletableEntityRepository<Product>>();

            //mockProductRepo.Setup(x => x.AllAsNoTracking()).Returns(list.AsQueryable());
            //mockProductRepo.Setup(x => x.AddAsync(It.IsAny<Product>())).Callback((Product x) => list.Add(x));
            //mockProductRepo.Setup(x => x.Delete(It.IsAny<Product>())).Callback((Product x) => x.IsDeleted = true);


        }
    }
}
