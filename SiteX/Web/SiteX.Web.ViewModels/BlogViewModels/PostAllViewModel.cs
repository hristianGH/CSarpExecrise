using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.BlogViewModels
{
    public class PostAllViewModel:PagingViewModel
    {
        public ICollection<PostOutViewModel> Posts { get; set; } = new List<PostOutViewModel>();
        //public ToSelectList ToSelectList { get; set; }

    }
}
