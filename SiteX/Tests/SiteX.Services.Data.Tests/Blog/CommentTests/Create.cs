using Moq;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Blog;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.BlogService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SiteX.Services.Data.Tests.Blog.CommentTests
{
    public class Create
    {
        //[Fact]
        //public async Task CreateColorShouldCreateName()
        //{
        //    var list = new List<Comment>();

        //    var mockRepo = new Mock<IRepository<Comment>>();

        //    mockRepo.Setup(x => x.AllAsNoTracking()).Returns(list.AsQueryable());
        //    mockRepo.Setup(x => x.AddAsync(It.IsAny<Comment>())).Callback((Comment x) => list.Add(x));
        //    var service = new CommentService(mockRepo.Object);

        //    var name = "Test Color";
        //    var color = new Comment() { Id = 1, Name = name };

        //    await service.CreateAsync(color);

        //    Assert.True(list.Count() > 0);
        //    Assert.Equal(name, list[0].Name);
        //}
    }
}
