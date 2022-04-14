using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.BlogViewModels
{
    public class ToSelectedList
    {
        public IEnumerable<Genre> GenresToList { get; set; } = new List<Genre>();
    }
}
