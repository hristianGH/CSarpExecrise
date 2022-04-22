using Moq;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService;
using SiteX.Services.Data.ShopService.Interface;
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
        //[Fact]
        //public async Task CreateProductShouldWork()
        //{
        //    var list = new List<Product>();

        //    var mockRepo = new Mock<IDeletableEntityRepository<Product>>();

        //    mockRepo.Setup(x => x.AllAsNoTracking()).Returns(list.AsQueryable());
        //    mockRepo.Setup(x => x.AddAsync(It.IsAny<Product>())).Callback((Product x) => list.Add(x));
        //    var service = new ProductService();

        //    await service.CreateAsync();

        //    Assert.True(list.Count() > 0);
        //    Assert.Equal(name, list[0].Name);
        //}

    }
}
