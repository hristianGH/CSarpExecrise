using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._1.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carAvg = new List<Car>();
            List<Truck> truckAvg = new List<Truck>();
            List<Calc> calc = new List<Calc>();
            List<Auto> car = new List<Auto>();


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
                if (input[0]=="car")
                {
                    type = "Car";
                    Car newCar = new Car(type, horsePower);
                    carAvg.Add(newCar);
                }
                else if (input[0]=="truck")
                {
                    type = "Truck";

                    Truck newTruck = new Truck(type, horsePower);
                    truckAvg.Add(newTruck);
                }

                Auto newAuto = new Auto(type, model, color, horsePower);
                car.Add(newAuto);
                Calc newVehicle = new Calc(type, horsePower);
                calc.Add(newVehicle);


            }
            StringBuilder sb = new StringBuilder();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[1] != "Close")
            {
                //int index = car.FindIndex(x => x.Model == input[0]);
                Auto[] model = car.Where(x => x.Model == input[0]).ToArray();
                //string[] modelAndType = { vehicle[index].HorsePower, vehicle[index].Type };
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in model)
                {
                    Console.WriteLine($"Type: {item.Type}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Horsepower: {item.HorsePower}");
 
                }
            }
            if (carAvg.Count>0)
            {
            double cAvg = carAvg.Select(x => x.HorsePower).Average();
            Console.WriteLine($"Cars have average horsepower of: {cAvg:f2}.");
            }
            if (truckAvg.Count>0)
            {
            double tAvg = truckAvg.Select(x => x.HorsePower).Average();
            Console.WriteLine($"Trucks have average horsepower of: {tAvg:f2}.");

            }


                //foreach (var auto in model)
                //{
                //    sb.AppendLine($"Type: {auto.Type}");
                //    sb.AppendLine($"Model: {auto.Model}");
                //    sb.AppendLine($"Color: {auto.Color}");
                //    sb.AppendLine($"Horsepower: {auto.HorsePower}");
                //    Console.WriteLine(sb.ToString());
                //    sb.Clear();
                //}
        }
    }
    class Truck
    {
        public Truck(string type, int horsePower)
        {
            Type = type;
            HorsePower = horsePower;

        }
        public string Type { get; set; }
        public int HorsePower { get; set; }
         
    }
    class Car
    {
        public Car(string type, int horsePower)
        {
            Type = type;
            HorsePower = horsePower;

        }
        public string Type { get; set; }
        public int HorsePower { get; set; }
    }
    class Auto
    {
        public Auto(string type, string model, string color, int horsePower)
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
        public Calc(string type, int horseP)
        {
            if (type == "Truck")
            {
                Truck = type;
            }
            else
            {
                Car = type;
            }
            HorsePower = horseP;
        }

        public string Type { get; set; }
        public string Car { get; set; }
        public string Truck { get; set; }
        public int HorsePower { get; set; }

    }

}
