using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteX.Services.Data
{
    public class GenderService : IGenderService
    {
        private readonly IRepository<Gender> genderRepository;
        public GenderService(IRepository<Gender> gender)
        {
            this.genderRepository = gender;
        }
        public Dictionary<string, string> GetGenderAsKVP()
        {

            return this.genderRepository.All().Select(x => new { x.Id, x.Name }).ToList().ToDictionary(x=>x.Id.ToString(),x=>x.Name);

                // return this.categoriesRepository.AllAsNoTracking()
                //.Select(x => new
                //{
                //    x.Id,
                //    x.Name,
                //})
                //.OrderBy(x => x.Name)
                //.ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }


    }
}
