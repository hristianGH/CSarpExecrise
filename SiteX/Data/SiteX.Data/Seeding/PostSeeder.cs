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
            //dbContext.Database.EnsureCreated();
            //if (dbContext.Posts.Any())
            //{
            //    return;
            //}
            //if (dbContext.Users.Count() > 0)
            //{
            //    string title = "Grand opening of our online shop SiteX";
            //    string body = "This online shop is like no other.Our locations are all over the world.You are welcomed at every single one of them.How lucky.";
            //    var images = new List<PostImage>();

            //    images.Add(new PostImage() { Path = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fstatic.vecteezy.com%2Fsystem%2Fresources%2Fpreviews%2F000%2F084%2F732%2Foriginal%2Fvector-grand-opening-retro-style-background.jpg&f=1&nofb=1" });
            //    var user = dbContext.Users.FirstOrDefault();
            //    var posts = new Post(){Title=title,Body=body,User=user,PostImages= images };
            //   await dbContext.Posts.AddAsync(posts);


            //}
            

        }


    }
}
