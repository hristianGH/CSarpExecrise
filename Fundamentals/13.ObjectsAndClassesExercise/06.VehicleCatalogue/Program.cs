using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Calc> vehicle = new List<Calc>();
            List<Truck> truck = new List<Truck>();
            //List<Car> car = new List<Car>();
            //List<int> avgHorseCars = new List<int>();
            //List<int> avgHorseTrucks = new List<int>();

            string[] input = new string[4];
            while (true)
            {
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }

                string type = input[0];
                string model = input[1];
                string color = input[2];
                int horsePower = int.Parse(input[3]);
                 
                Truck newTruck = new Truck(type, model, color, horsePower);
                truck.Add(newTruck);
                Calc newVehicle = new Calc(type, horsePower);
                vehicle.Add(newVehicle);
               // avgHorseTrucks.Add(horsePower);

                //switch (input[0])
                //{
                //    case "truck":
                //        type = "truck";
                //        Truck newTruck = new Truck(type, model, color, horsePower);
                //        truck.Add(newTruck);
                //        Calc newVehicle = new Calc("truck", model);
                //        vehicle.Add(newVehicle);
                //        avgHorseTrucks.Add(horsePower);
                //        break;
                //    case "car":
                //        type = "car";
                //        Car newCar = new Car(type, model, color, horsePower);
                //        car.Add(newCar);
                //          newVehicle = new Calc("car", model);
                //        vehicle.Add(newVehicle);
                //        avgHorseCars.Add(horsePower);
                //        break;
                //    default:
                //        break;
                //}


            }
            StringBuilder sb = new StringBuilder();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Close" && input[1] != "the")
            {
                int index = vehicle.FindIndex(x => x.HorsePower == input[0]);
                string[] modelAndType= { vehicle[index].HorsePower, vehicle[index].Type };
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


            //foreach (Car viacle in car)
            //{
            //    sb.AppendLine($"Type: {viacle.Type}");
            //    sb.AppendLine($"Model:{viacle.Model}");
            //    sb.AppendLine($"Color:{viacle.Color}");
            //    sb.AppendLine($"Horsepower:{viacle.HorsePower}");

            //}
            //foreach (Truck viacle in truck)
            //{
            //    sb.AppendLine($"Type: {viacle.Type}");
            //    sb.AppendLine($"Model:{viacle.Model}");
            //    sb.AppendLine($"Color:{viacle.Color}");
            //    sb.AppendLine($"Horsepower:{viacle.HorsePower}");
            //}
            //Console.WriteLine(sb.ToString());
        }
    }
}
//class Car
//{
//    public Car(string type, string model, string color, int horsePower)
//    {
//        Type = type;
//        Model = model;
//        Color = color;
//        HorsePower = horsePower;

//    }
//    public string Type { get; set; }
//    public int HorsePower { get; set; }
//    public string Color { get; set; }
//    public string Model { get; set; }
//}
class Truck
{
    public Truck(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }
    public string Type { get; set; }

    public int HorsePower { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
}
class Calc
{
    public Calc(string type,int horseP)
    {
        Type = type;
        HorsePower = horseP;
    }
    public string Type { get; set; }
    public int HorsePower { get; set; }

}
