namespace SiteX.Services.Data.ShopService
{
    using SiteX.Services.Data.ShopService.Interface;
    using SiteX.Web.ViewModels.ShopViewModels;

    public class ShopListService : IShopListService
    {
        private readonly IGenderService genderService;
        private readonly ICategoryService categoryService;
        private readonly ISizeService sizeService;
        private readonly IColorService colorService;
        private readonly ILocationService locationService;

        public ShopListService(
            IGenderService genderService,
            ICategoryService categoryService,
            ISizeService sizeService,
            IColorService colorService,
            ILocationService locationService)
        {
            this.genderService = genderService;
            this.categoryService = categoryService;
            this.sizeService = sizeService;
            this.colorService = colorService;
            this.locationService = locationService;
        }

        public ShopToSelectList ToSelectList()
        {
            var selectedList = new ShopToSelectList()
            {
                GendersToList = this.genderService.GetGenders(),
                CategoriesToList = this.categoryService.GetCategories(),
                SizesToList = this.sizeService.GetSizes(),
                ColorsToList = this.colorService.GetColors(),
                LocationsToList=this.locationService.GetLocations(),
            };
            return selectedList;
        }
    }
}
