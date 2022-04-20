namespace SiteX.Services.Data.ArticleService.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IArticleService
    {
        public Task CreateArticleAsync();

        public Task DeleteArticleAsync(int id);

        public Task CreateArticlesAsync();
    }
}
