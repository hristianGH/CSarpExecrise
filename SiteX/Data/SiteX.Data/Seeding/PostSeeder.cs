using Microsoft.AspNetCore.Identity;
using SiteX.Data.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    public class PostSeeder : ISeeder
    {
       
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            dbContext.Database.EnsureCreated();
            if (dbContext.Posts.Any())
            {
                return;
            }
            var hasher = new PasswordHasher<IdentityUser>();
            string body = "This body is about somethingThis body is about somethingThis body is about somethingThis body is about something";
            //await dbContext.Posts.AddAsync(new Post
            //{
            //    Title = "Post about something",
            //    Body = body
            //    ,
            //    User = new() { Email = "Elonmusk@abv.bg", UserName = "ElonMusk", PasswordHash = hasher.HashPassword(new IdentityUser(), "1234567") }
            //});
        }


    }
}
