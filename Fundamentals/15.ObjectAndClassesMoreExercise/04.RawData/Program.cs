using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];

                int engineSpeed = int.Parse(parts[1]);
                int enginePower = int.Parse(parts[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(parts[3]);
                string cargoType = parts[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(name, engine, cargo);

                cars.Add(car);
            }
            string typeCriteria = Console.ReadLine();
            
            if (typeCriteria == "fragile")
            {
                cars = cars.Where(c => c.CarsCargo.CargoType == "fragile" && c.CarsCargo.CargoWeight < 1000).ToList();
            }
            else
            {
                cars = cars.Where(c => c.CarsCargo.CargoType == "flamable" && c.CarsEngine.EnginePower > 250).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }

    class Car
    {
        public Car(string name, Engine engine, Cargo cargo)
        {
            this.CarModel = name;
            this.CarsEngine = engine;
            this.CarsCargo = cargo;
        }
        public string CarModel { get; set; }
        public Engine CarsEngine { get; set; }

        public Cargo CarsCargo { get; set; }

        public override string ToString()
        {
            return this.CarModel;
        }

    }
    class Engine
    {
        public Engine(int speed,int power)
        {
            this.EnginePower = power;
            this.EngineSpeed = speed;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.CargoWeight = weight;
            this.CargoType = type;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
