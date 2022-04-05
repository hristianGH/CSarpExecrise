using Microsoft.AspNetCore.Identity;
using SiteX.Data.Common.Repositories;
using SiteX.Data.Models;
using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Seeding
{
    public class ProductSeeder : ISeeder
    {
         
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Count() > 0&&dbContext.Products.Count()<5)
            {
                var locations = new List<Location>();
                locations.Add(dbContext.Locations.Select(x => new Location { Name = x.Name, Address = x.Address }).FirstOrDefault());
                Gender gender = dbContext.Genders.Select(x => new Gender {  Name = x.Name }).FirstOrDefault();
                var pictures = new List<ProductImage>();
                pictures.Add(new ProductImage() { Path = "Pic" });

                var products = new List<Product>();
                for (int i = 0; i < 8; i++)
                {

                    products.Add(new Product()
                    {
                        Name = "White Shirt"
                       ,
                        Gender = gender.ToString()
                       ,
                        User = null
                       ,
                        Price = 12
                       ,
                        Description = "This is a test item"
                       ,
                        ProductImages = pictures
                      ,
                       
                    }) ;
            }
                  dbContext.AddRange(products);

        }
    }
}
}
