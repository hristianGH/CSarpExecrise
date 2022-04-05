using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> locationRepository;

        public LocationService(IRepository<Location> locationRepository)
        {
            this.locationRepository = locationRepository;
        }

        public async Task CreateAsync(LocationViewModel viewModel)
        {

            var location = new Location() { Name = viewModel.Name, Adress = viewModel.Address };
            await this.locationRepository.AddAsync(location);
            await this.locationRepository.SaveChangesAsync();


        }

        public Dictionary<string, string> GetLocationAsKVP()
        {
            var dictionary = this.locationRepository.AllAsNoTracking().Select(x => new { x.Name, x.Adress }).ToDictionary(x => x.Name, x => x.Adress);
            return dictionary;

        }
        public IEnumerable<Location> GetLocations()
        {
            //var locations = this.locationRepository.AllAsNoTracking().Select(x => $"{x.Name}, {x.Adress}").ToArray();
            var locations = this.locationRepository.AllAsNoTracking().ToArray();
            return locations;
        }

    }
}
