using System;
using System.IO;
using CarDealer.Data;
using CarDealer.Data.Context;
using System.Text.Json;

using System.Linq;

namespace CarDealer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CarDealerContext dbContext = new CarDealerContext();
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
             //string input = File.ReadAllText("../../../Datasets/cars.json");
            


        }
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var deserialize = JsonSerializer.Deserialize<Supplier[]>(inputJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            context.Suppliers.AddRange(deserialize);
            context.SaveChanges();
            return $"Successfully imported {deserialize.Length}.";
        }
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var deserialize = JsonSerializer.Deserialize<Part[]>(inputJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true })
                .Where(x => x.SupplierId < 31).ToArray();
            context.Parts.AddRange(deserialize);
            context.SaveChanges();
            return $"Successfully imported {deserialize.Count()}.";
        }
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var deserialize = JsonSerializer.Deserialize<Car[]>(inputJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            context.Cars.AddRange(deserialize);
            ;
            context.SaveChanges();
            return $"Successfully imported {deserialize.Count()}.";
        }
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var deserialize = JsonSerializer.Deserialize<Customer[]>(inputJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            context.Customers.AddRange(deserialize);
            context.SaveChanges();
            return $"Successfully imported {deserialize.Count()}.";
        }
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var deserialize = JsonSerializer.Deserialize<Sale[]>(inputJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            context.Sales.AddRange(deserialize);
            context.SaveChanges();
            return $"Successfully imported {deserialize.Count()}.";
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers.OrderBy(x => x.BirthDate).ThenBy(x => x.IsYoungDriver).ToArray();
            return (JsonSerializer.Serialize(customers, new JsonSerializerOptions { WriteIndented = true }));
        }
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars.Where(x => x.Make == "Toyota").OrderBy(x => x.Model).ThenByDescending(x => x.TravelledDistance).ToArray();
            ;
            return (JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = true }));
        }
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var parts = context.Parts.Select(x=>new {x.Id,x.SupplierId });
            var suppliers = context.Suppliers.Where(x=>x.IsImporter==false).Select(x=>new {x.Id,x.Name,PartsCounts= parts.Where(y=>y.SupplierId==x.Id).Count() }).ToArray();
            ;
            return (JsonSerializer.Serialize(suppliers, new JsonSerializerOptions { WriteIndented = true }));
        }
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var parts = context.Parts.Select(x => new { x.Id, x.Name, x.Price });
            var cars = context.Cars.ToArray();
            ;
            return (JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
