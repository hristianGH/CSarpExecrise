using Microsoft.AspNetCore.Identity;
using SiteX.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    internal class UserSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if(dbContext.Users.Any())
            {
                return;
            }
            var hasher = new PasswordHasher<IdentityUser>();

            //await dbContext.Users.AddAsync(new UserX
            //{
                
            //     Email = "Elonmusk@abv.bg", UserName = "ElonMusk", PasswordHash = hasher.HashPassword(new IdentityUser(), "1234567") 
            //});

        }
    }
}
