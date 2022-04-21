namespace SiteX.Services.Data.ArticleService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AngleSharp;
    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Article;
    using SiteX.Services.Data.ArticleService.Interface;

    public class ArticleService : IArticleService
    {
        private readonly IDeletableEntityRepository<Article> arcticleRepo;
        private readonly IConfiguration configuration;
        private readonly IBrowsingContext context;

        public ArticleService(IDeletableEntityRepository<Article> arcticleRepo)
        {
            this.arcticleRepo = arcticleRepo;
            this.configuration = Configuration.Default.WithDefaultLoader();
            this.context = BrowsingContext.New(configuration);
        }

        public Task CreateArticleAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CreateArticlesAsync()
        {
            var articles = new List<Article>();
            Parallel.For(35_438_900, 35_439_900, (i) =>
            {
                var article = GetArticle(this.context, i);
                if (article != null)
                {
                    articles.Add(article);
                }
            });
            foreach (var article in articles)
            {
               await this.arcticleRepo.AddAsync(article);
            }
        }

        public static Article GetArticle(IBrowsingContext context, int id)
        {
            var article = new Article();
            var document = context.OpenAsync($"https://pubmed.ncbi.nlm.nih.gov/{id}/").GetAwaiter().GetResult();

            var name = document.QuerySelector(".heading-title");
            var desc = document.QuerySelector(".abstract-content");
            var idlink = document.QuerySelector(".id-link");

            var currLink = document.BaseUrl;

            if (name != null && desc != null && idlink != null)
            {
                article.Title = name.TextContent;
                article.Abstract = desc.TextContent;
                article.IdLink = idlink.TextContent;
                article.Url = currLink.Href;
                return article;
            }

            return article;
        }

        public Task DeleteArticleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetArticles()
        {
           return this.arcticleRepo.AllAsNoTracking().ToList();
        }

        public ICollection<Article> ToPage(int page = 1, int itemsPerPage = 6)
        {
            var output = this.arcticleRepo.AllAsNoTracking().Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToList();
            return output;
        }

        public int GetArticlesCount()
        {
            return this.arcticleRepo.AllAsNoTracking().Count();
        }

        public Article GetArticleById(int id)
        {
            return this.arcticleRepo.AllAsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}
