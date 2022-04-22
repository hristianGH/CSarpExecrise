using SiteX.Data.Models.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Web.ViewModels.ArticleViewModels
{
    public class AllArticleViewModel : PagingViewModel
    {
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
