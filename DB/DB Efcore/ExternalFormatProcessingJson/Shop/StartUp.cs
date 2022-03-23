using System;
using Shop.Data;
using Shop.Data.Models;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Text;


namespace Shop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ProductShopContext shopDb = new ProductShopContext();
            //shopDb.Database.EnsureDeleted();
            //shopDb.Database.EnsureCreated();
            //string data = File.ReadAllText("../../../Datasets/categories-products.json");
            GetUsersWithProducts(shopDb) ;

        }
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            // inputJson += "users.json";
            var users = JsonConvert.DeserializeObject<UserInput[]>(inputJson);
            context.Users.AddRange(users.Select(x => new User { FirstName = x.FirstName, LastName = x.LastName, Age = x.Age }));
            context.SaveChanges();
            return $"Successfully imported {users.Length + 1}";
        }
      
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            //inputJson += "products.json";
            var products = JsonConvert.DeserializeObject<Product[]>(inputJson);
            context.Products.AddRange(products);
            context.SaveChanges();
            return $"Successfully imported {products.Length + 1}";
        }
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<Category[]>(inputJson);
            context.Categories.AddRange(categories);
            context.SaveChanges();
            return $"Successfully imported {categories.Length + 1}";
        }
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {

            var categoryProducts = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);
            ;
            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();
            return $"Successfully imported {categoryProducts.Length + 1}";
        }
        public static string GetProductsInRange(ProductShopContext context)
        {

            var aa = context.Products.Select(x => new { x.Name, x.Price, Seller = (x.Seller.FirstName + " " + x.Seller.LastName) })
                 .Where(x => x.Price >= 500 && x.Price <= 1000).OrderBy(x => x.Price).ToList();

            string converted = JsonConvert.SerializeObject(aa, Formatting.Indented);
            return converted;

        }
        public static string GetSoldProducts(ProductShopContext context)
        {
            var soldProd = context.Users.Where(x => x.ProductsSold.Count > 0)
                    .Select(x => new
                    {
                        x.FirstName,
                        x.LastName,
                        SoldItems = x.ProductsSold.Where(x => x.BuyerId != null)
                        .Select(x => new
                        {
                            Name = x.Name,
                            Price = x.Price,
                            BuyerFirstName = x.Buyer.FirstName,
                            BuyerLastName = x.Buyer.LastName
                        })
                    })
                    .OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            string converted = JsonConvert.SerializeObject(soldProd, Formatting.Indented);

            return converted;

        }
        public static void GetUsersWithProducts(ProductShopContext context)
        {
            
            var soldProd = context.Users.Where(x => x.ProductsSold.Count > 0)
                   .Select(x => new
                   {
                        
                       x.LastName,
                       x.Age,
                       SoldItems = x.ProductsSold.Where(x => x.BuyerId != null)
                       .Select(x => new
                       {
                           Name = x.Name,
                           Price = x.Price,
                       })
                   });
            ;
        }
        
    }
}
