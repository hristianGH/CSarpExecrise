namespace SiteX.Web.ViewModels.BlogViewModels
{
    using System.Collections.Generic;

    public class PostAllViewModel : PagingViewModel
    {
        public ICollection<PostOutViewModel> Posts { get; set; } = new List<PostOutViewModel>();
    }
}
