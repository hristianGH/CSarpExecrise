using SiteX.Data.Common.Repositories;
using SiteX.Data.Models.Shop;
using SiteX.Services.Data.ShopService.Interface;
using SiteX.Web.ViewModels.ShopViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Services.Data.ShopService
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> locationRepository;
        private readonly IRepository<ProductLocation> productLocationRepository;

        public LocationService(IRepository<Location> locationRepository,
            IRepository<ProductLocation> productLocationRepository)
        {
            this.locationRepository = locationRepository;
            this.productLocationRepository = productLocationRepository;
        }

        public async Task CreateAsync(LocationViewModel viewModel)
        {

            var location = new Location() { Name = viewModel.Name, Address = viewModel.Address };
            await this.locationRepository.AddAsync(location);
            await this.locationRepository.SaveChangesAsync();


        }

        public async Task EditAsync(LocationEditViewModel location)
        {
            var locationEdit = locationRepository.All().FirstOrDefault(x => x.Id == location.OldId);
            locationEdit.Name = location.NewName;
            locationEdit.Address = location.NewAddress;

            await this.locationRepository.SaveChangesAsync();
        }

        public Dictionary<string, string> GetLocationAsKVP()
        {
            var dictionary = this.locationRepository.AllAsNoTracking().Select(x => new { x.Id, x.Address }).ToDictionary(x => x.Id.ToString(),x=>x.Address);
            return dictionary;

        }
        public IEnumerable<Location> GetLocations()
        {
            var locations = this.locationRepository.AllAsNoTracking().ToArray();
            return locations;
        }

        public ICollection<Location> GetLocationsByProductId(Guid id)
        {
            var productLocations = productLocationRepository.AllAsNoTracking().Where(x => x.ProductId == id).ToList();
            List<Location> locations = new List<Location>();
            var all = locationRepository.AllAsNoTracking().ToList();
            foreach (var location in productLocations)
            {
                var name = all.Where(x => x.Id == location.LocationId).Select(x=>x.Name).ToString();
                locations.Add(new Location { Id = location.LocationId, Name = name });
            }
            return locations;
        }
    }
}
