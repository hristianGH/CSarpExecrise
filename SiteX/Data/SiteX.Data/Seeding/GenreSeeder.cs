using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    public class GenreSeeder:ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {

            if (dbContext.Genres.Any())
            {
                return;
            }

            dbContext.Add(new Genre { Name = "Life and Living" });
            dbContext.Add(new Genre { Name = "Life and Dying" });
            dbContext.Add(new Genre { Name = "Life and Health" });
            dbContext.Add(new Genre { Name = "Tech and Living" });
            dbContext.Add(new Genre { Name = "Tech and Dying" });
            dbContext.Add(new Genre { Name = "Tech and Health" });
            dbContext.Add(new Genre { Name = "Misc" });



        }
    }
}
