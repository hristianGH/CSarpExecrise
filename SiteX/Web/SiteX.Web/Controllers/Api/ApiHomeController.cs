namespace SiteX.Web.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using SiteX.Data.Models.Blog;

    [Route("/api/[controller]")]
    [ApiController]
    public class ApiHomeController : Controller
    {
        [HttpGet]
        public IActionResult GetPost(Post post)
        {
            return this.Ok(post);
        }

        [HttpPost]
        public IActionResult CreatePost([FromForm] Post post)
        {
            return this.Ok();
        }
    }
}
