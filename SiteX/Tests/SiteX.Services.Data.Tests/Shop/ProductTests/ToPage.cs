using Moq;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService;
using SiteX.Services.Mapping;
using SiteX.Web.ViewModels;
using SiteX.Web.ViewModels.ShopViewModels.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace SiteX.Services.Data.Tests.Shop.ProductTests
{
    public class ToPage
    {
        [Fact]
        public async Task ToPageSholdReturnProducts()
        {
            var list = new List<Product>();

            AutoMapperConfig.RegisterMappings(typeof(IndexViewModel).GetTypeInfo().Assembly);

            var mockProductRepo = new Mock<IDeletableEntityRepository<Product>>();

            mockProductRepo.Setup(x => x.AllAsNoTracking()).Returns(list.AsQueryable());

            mockProductRepo.Setup(x => x.AddAsync(It.IsAny<Product>())).Callback((Product x) => list.Add(x));

            var service = new ProductService(mockProductRepo.Object);
            var guid = Guid.NewGuid();
            for (int i = 0; i < 15; i++)
            {

                var product = new ProductViewModel()
                {
                    Name = "Big Shirt",
                    Price = 12,
                    Gender = "Unisex",
                    Categories = new int[] { 1, 2, 3 },
                    Locations = new int[] { 1 },
                    Colors = new int[] { 1, 2 },
                    Sizes = new int[] { 1, 2 },
                    Pictures = new string[] { "image1", "image2" },
                    Quantity = 22,
                    Id = guid,
                    Description = "Product",

                };
                await service.CreateAsync(product);
                list[i].Id = guid;
                guid = Guid.NewGuid();
            }

            for (int i = 1; i <= 20; i++)
            {
                var page = service.ToPage(i, 6);
                if (Math.Ceiling((double)list.Count / 6) >= i)
                {
                    Assert.True(page.Any());
                }
                else
                {
                    Assert.True(page.Count == 0);
                }
            }

        }
    }
}
