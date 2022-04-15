namespace SiteX.Services.Data.ShopService.Interface
{
    using SiteX.Web.ViewModels.ShopViewModels;

    public interface IShopListService
    {
        public ShopToSelectList ToSelectList();
    }
}
