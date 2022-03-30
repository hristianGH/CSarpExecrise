using SiteX.Data.Models.Blog;

namespace SiteX.ViewModels
{
    public class IndexViewModel
    {
        public int PostCount { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
