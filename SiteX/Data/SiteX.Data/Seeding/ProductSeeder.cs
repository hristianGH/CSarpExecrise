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
            if (dbContext.Users.Count() > 0&&dbContext.Products.Count()<=60)
            {
                // TODO MAYBE ADD LOCATION AND CATEGORY DONT KNOW
                var locations = new List<Location>();
                locations.Add(dbContext.Locations.Select(x => new Location { Name = x.Name, Address = x.Address }).FirstOrDefault());
                Gender gender = dbContext.Genders.Select(x => new Gender {  Name = x.Name }).FirstOrDefault();
                var categories = new List<ProductCategory>();
                categories.Add(dbContext.ProductCategories.FirstOrDefault());
                var pictures = new List<ProductImage>();
                pictures.Add(new ProductImage() { Path = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2F736x%2F47%2F8e%2F46%2F478e46507d40bf9540538726d8f74afc--rat-rat-rats.jpg&f=1&nofb=1" });
                pictures.Add(new ProductImage() { Path = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2F736x%2F47%2F8e%2F46%2F478e46507d40bf9540538726d8f74afc--rat-rat-rats.jpg&f=1&nofb=1" });
                
                var products = new List<Product>();
                for (int i = 0; i < 80; i++)
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
                        ProductImages = new List<ProductImage>(pictures)
                       
                    }); ;
            }
                  dbContext.AddRange(products);

        }
    }
}
}
