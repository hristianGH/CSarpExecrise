namespace SiteX.Services.Data.ArticleService.Interface
{
    using SiteX.Data.Models.Article;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IArticleService
    {
        public Task CreateArticleAsync();

        public Task DeleteArticleAsync(int id);

        public Task CreateArticlesAsync();

        public Article GetArticleById(int id);

        public IEnumerable<Article> GetArticles();

        public ICollection<Article> ToPage(int page = 1, int itemsPerPage = 6);

        public int GetArticlesCount();

    }
}
