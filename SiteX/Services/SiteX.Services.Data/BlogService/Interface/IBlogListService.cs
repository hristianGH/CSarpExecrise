using SiteX.Web.ViewModels.BlogViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Services.Data.BlogService.Interface
{
    public interface IBlogListService
    {
        public BlogToSelectedList ToSelectedList();
    }
}
