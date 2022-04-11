namespace SiteX.Services.Data.ShopService.Interface
{
    using System.Collections.Generic;

    public interface IGenderService
    {
        Dictionary<string, string> GetGenderAsKVP();

        public IEnumerable<string> GetGenders();
    }
}
