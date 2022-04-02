using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteX.Services.Data
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> locationRepository;

        public LocationService(IRepository<Location> locationRepository)
        {
            this.locationRepository = locationRepository;
        }

            public Dictionary<string, string> GetLocationAsKVP()
            {
                var dictionary = this.locationRepository.AllAsNoTracking().Select(x => new {x.Name,x.Address }).ToDictionary(x => x.Name, x => x.Address);
                return dictionary;

            }
        public IEnumerable<string> GetLocations()
        {
            var locations = this.locationRepository.AllAsNoTracking().Select(x => $"{x.Name}, {x.Address}").ToArray();
            return locations;
        }

    }
}
