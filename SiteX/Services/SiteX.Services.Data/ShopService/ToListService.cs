namespace SiteX.Services.Data.ShopService
{
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels;

    public class ToListService : IToListService
    {
        private readonly IGenderService genderService;
        private readonly ICategoryService categoryService;
        private readonly ISizeService sizeService;
        private readonly IColorService colorService;

        public ToListService(
            IGenderService genderService,
            ICategoryService categoryService,
            ISizeService sizeService,
            IColorService colorService)
        {
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.sizeService = sizeService;
            this.colorService = colorService;
        }

        public ToSelectList ToSelectList()
        {
            var selectedList = new ToSelectList()
            {
                GendersToList = this.genderService.GetGenders(),

                CategoriesToList = this.categoryService.GetCategories(),

                SizesToList = this.sizeService.GetSizes(),

                ColorsToList = this.colorService.GetColors(),
            };

            return selectedList;
        }
    }
}
