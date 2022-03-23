using ProductShop.Data;
using ProductShop.Models;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ProductShop

{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ProductShopContext context = new ProductShopContext();

            //context.Database.EnsureCreated();
            //context.Database.EnsureDeleted();

            // var inputxml = File.ReadAllText("Datasets/users.xml");
            // var inputxml = File.ReadAllText("Datasets/products.xml");
            // var inputxml = File.ReadAllText("Datasets/categories.xml");
            // var inputxml = File.ReadAllText("Datasets/categories-products.xml");
            GetProductsInRange(context);

        }
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var usersXml = new XmlSerializer(typeof(User[]), new XmlRootAttribute("Users"));
           var users= usersXml.Deserialize(new StringReader(inputXml)) as User[];
            context.Users.AddRange(users);
            //context.SaveChanges();
            ;
            return $"Successfully imported {users.Length}";
        }
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var productsXml = new XmlSerializer(typeof(Product[]), new XmlRootAttribute("Products"));
            var products = productsXml.Deserialize(new StringReader(inputXml)) as Product[];
            context.Products.AddRange(products);
            //context.SaveChanges();
            ;
            return $"Successfully imported {products.Length}";
        }
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var categoriesXml = new XmlSerializer(typeof(Category[]), new XmlRootAttribute("Categories"));
            var categories = categoriesXml.Deserialize(new StringReader(inputXml)) as Category[];
            context.Categories.AddRange(categories);
            //context.SaveChanges();
            ;
            return $"Successfully imported {categories.Length}";
        }
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var categoryProductsXml = new XmlSerializer(typeof(CategoryProduct[]), new XmlRootAttribute("CategoryProducts"));
            var categoryProducts = categoryProductsXml.Deserialize(new StringReader(inputXml)) as CategoryProduct[];
            context.CategoryProducts.AddRange(categoryProducts);
            //context.SaveChanges();
            ;
            return $"Successfully imported {categoryProducts.Length}";
        }
        public static void GetProductsInRange(ProductShopContext context)
        {
          var contacts= context.Products.Where(x => x.Price >= 500 && x.Price <= 1000).Select(x => 
            new { x.Name, x.Price,
                BuyerName = $"{x.Buyer.FirstName} {x.Buyer.LastName}" })
                .OrderBy(x=>x.Price).ThenBy(x=>x.BuyerName).Take(10);
           // var serializer = new XmlSerializer(typeof(string));
            foreach (var item in contacts)
            {
                System.Console.WriteLine($"{item.Name} {item.Price} {item.BuyerName}");
            }
           // serializer.Serialize(System.Console.Out, contacts);
            
            ;
        }
    }
}