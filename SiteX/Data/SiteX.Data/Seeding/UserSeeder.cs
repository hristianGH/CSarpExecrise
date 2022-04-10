using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SiteX.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    public class UserSeeder : ISeeder
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserSeeder(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {

            if (dbContext.Users.Any(x => x.UserName == "admin@admin.com"))
            {
                return;
            }
            var admin = new ApplicationUser() { UserName = "admin@admin.com", Email = "admin@admin.com", EmailConfirmed = false };
            string pass = "password123";
            await userManager.CreateAsync(admin, pass);
            await userManager.AddToRoleAsync(admin, "Administrator");
            if (dbContext.UserRoles.Any())
            {
                return;
            }
            var roleId = dbContext.Roles.Select(x => x.Id).FirstOrDefault();
            var adminId = dbContext.Users.Where(x => x.UserName == "admin@admin.com").Select(x => x.Id).FirstOrDefault();

            dbContext.UserRoles.Add(new IdentityUserRole<string>() { RoleId = roleId, UserId = adminId });
        }

    }
}
