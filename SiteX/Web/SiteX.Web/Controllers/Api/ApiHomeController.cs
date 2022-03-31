using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteX.Data.Models.Blog;
using SiteX.Data.Models.Shop;
using System.Threading.Tasks;

namespace SiteX.Web.Controllers.Api
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ApiHomeController : Controller
    {
        [HttpGet]
        public  IActionResult GetPost(Post post)
        {
            return this.Ok(post);
        }


        [HttpPost]
        public async Task<IActionResult> CreatePost([FromForm]Post post)
        {
             
            return this.Ok();
        }
    }
}
