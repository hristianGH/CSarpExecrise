using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    public class ColorSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Colors.Any())
            {
                return;
            }
            await dbContext.Colors.AddAsync(new Color() { Name = "Black" });
            await dbContext.Colors.AddAsync(new Color() { Name = "White" });
            await dbContext.Colors.AddAsync(new Color() { Name = "Green" });
            await dbContext.Colors.AddAsync(new Color() { Name = "Blue" });
            await dbContext.Colors.AddAsync(new Color() { Name = "Red" });
            await dbContext.Colors.AddAsync(new Color() { Name = "Cyan" });

        }
    }
}
