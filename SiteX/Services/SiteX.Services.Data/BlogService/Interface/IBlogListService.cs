﻿namespace SiteX.Services.Data.BlogService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SiteX.Web.ViewModels.BlogViewModels;

    public interface IBlogListService
    {
        public BlogToSelectedList ToSelectedList();
    }
}
