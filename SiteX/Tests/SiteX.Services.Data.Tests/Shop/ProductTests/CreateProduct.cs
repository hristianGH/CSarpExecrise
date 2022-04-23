using Moq;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SiteX.Services.Data.Tests.Shop.ProductTests
{
    public class CreateProduct
    {
        [Fact]
        public async Task CreateProductShouldWork()
        {
            var list = new List<Product>();

            var mockProductRepo = new Mock<IDeletableEntityRepository<Product>>();

            mockProductRepo.Setup(x => x.AllAsNoTracking()).Returns(list.AsQueryable());
            mockProductRepo.Setup(x => x.AddAsync(It.IsAny<Product>())).Callback((Product x) => list.Add(x));
            var service = new ProductService(mockProductRepo.Object);


            Assert.True(list.Count() > 0);
        }

    }
}
