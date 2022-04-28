namespace SiteX.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SiteX.Data.Models.Shop;

    public class ProductSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Count() > 0 && dbContext.Products.Count() <= 40)
            {
                var locations = new List<Location>();
                locations.Add(dbContext.Locations.Select(x => new Location { Name = x.Name, Address = x.Address }).FirstOrDefault());
                Gender gender = dbContext.Genders.Select(x => new Gender { Name = x.Name }).FirstOrDefault();
                var categories = new List<ProductCategory>();
                categories.Add(dbContext.ProductCategories.FirstOrDefault());
                var pictures = new List<ProductImage>();
                pictures.Add(new ProductImage() { Path = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2F736x%2F47%2F8e%2F46%2F478e46507d40bf9540538726d8f74afc--rat-rat-rats.jpg&f=1&nofb=1" });
                var colors = new List<ProductColor>();
                colors.Add(new ProductColor() { ColorId = 1 });
                var products = new List<Product>();
                for (int i = 0; i < 40; i++)
                {
                    var productToAdd= new Product()
                    {
                        Name = "White Shirt",
                        Gender = gender.Name,
                        User = null,
                        Price = 12,
                        Description = "This is a test item",
                    };
                    productToAdd.ProductCategories.Add(new ProductCategory() { ProductId = productToAdd.Id, CategoryId = 1 });
                    productToAdd.ProductImages.Add(new ProductImage() { ProductId = productToAdd.Id, Path = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimg.shein.com%2Fimages%2Fshein.com%2F201605%2F1464060544868371186.jpg&f=1&nofb=1" });
                    productToAdd.ProductLocations.Add(new ProductLocation() { ProductId = productToAdd.Id, LocationId = 1 });
                    productToAdd.ProductColors.Add(new ProductColor() { ProductId = productToAdd.Id, ColorId = 1 });
                    productToAdd.ProductSizes.Add(new ProductSize() { ProductId = productToAdd.Id, SizeId = 1 });
                    products.Add(productToAdd);
                }

                dbContext.AddRange(products);
                dbContext.SaveChanges();
            }
        }
    }
}
