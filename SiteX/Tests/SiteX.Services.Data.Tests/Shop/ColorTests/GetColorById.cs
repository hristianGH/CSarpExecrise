﻿using Moq;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SiteX.Services.Data.Tests.Shop.ColorTests
{
    public class GetLocationById
    {
            [Fact]
            public async Task GetColorByIdShouldReturnValue()
            {
                var list = new List<Color>();

                var mockRepo = new Mock<IRepository<Color>>();

                mockRepo.Setup(x => x.AllAsNoTracking()).Returns(list.AsQueryable());
                mockRepo.Setup(x => x.AddAsync(It.IsAny<Color>())).Callback((Color x) => list.Add(x));
                var service = new ColorService(mockRepo.Object);

                for (int i = 0; i < 10; i++)
                {
                    list.Add(new Color() { Id = i, Name = "Name" });
                }

                var result = service.GetColorById(5);

                Assert.Equal(5, result.Id);
            }
    }
}
