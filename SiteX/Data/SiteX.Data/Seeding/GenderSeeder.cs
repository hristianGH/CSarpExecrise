using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    public class GenderSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {

            if (dbContext.Genders.Any())
            {
                return;
            }

           await dbContext.Genders.AddAsync(new Gender { Name = "Male" });
            await dbContext.Genders.AddAsync(new Gender { Name = "Female" });
          await  dbContext.Genders.AddAsync(new Gender { Name = "Unisex" });

        }
    }
}
