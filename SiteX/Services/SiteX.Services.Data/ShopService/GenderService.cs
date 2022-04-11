namespace SiteX.Services.Data.ShopService
{
    using System.Collections.Generic;
    using System.Linq;

    using SiteX.Data.Common.Repositories;
    using SiteX.Data.Models.Shop;
    using SiteX.Services.Data.ShopService.Interface;

    public class GenderService : IGenderService
    {
        private readonly IRepository<Gender> genderRepository;

        public GenderService(IRepository<Gender> repository)
        {
            this.genderRepository = repository;
        }

        public Dictionary<string, string> GetGenderAsKVP()
        {
            var dictionary = this.genderRepository.AllAsNoTracking().Select(x => new { x.Id, x.Name }).ToDictionary(x => x.Id.ToString(), x => x.Name);
            return dictionary;
        }

        public IEnumerable<string> GetGenders()
        {
            var genders = this.genderRepository.AllAsNoTracking().Select(x => x.Name).ToArray();
            return genders;
        }
    }
}
