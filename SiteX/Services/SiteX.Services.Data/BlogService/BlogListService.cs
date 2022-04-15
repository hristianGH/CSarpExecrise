namespace SiteX.Services.Data.BlogService
{
    using SiteX.Services.Data.BlogService.Interface;
    using SiteX.Web.ViewModels.BlogViewModels;

    public class BlogListService : IBlogListService
    {
        private readonly IGenreService genreService;

        public BlogListService(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        public BlogToSelectedList ToSelectedList()
        {
            var selectedList = new BlogToSelectedList()
            {
                GenresToList = this.genreService.GetGenres(),
            };

            return selectedList;
        }
    }
}
