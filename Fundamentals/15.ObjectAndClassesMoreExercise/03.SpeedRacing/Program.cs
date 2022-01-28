using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
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
                double fuel = double.Parse(parts[1]);
                double consumption = double.Parse(parts[2]);
                Car car = new Car(name, fuel, consumption);

                if (!cars.Any(c => c.CarModel == name))
                {
                    cars.Add(car);
                }
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                string name = parts[1];
                int distance = int.Parse(parts[2]);

                Car car = cars.Find(c => c.CarModel == name);
                car.Drive(distance);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }

    class Car
    {
        public Car(string name, double fuel, double consumption)
        {
            this.CarModel = name;
            this.CarFuel = fuel;
            this.CarConsumptionPerKM = consumption;
            this.TraveledDistance = 0;
        }
        public string CarModel { get; set; }
        public double CarFuel { get; set; }
        public double CarConsumptionPerKM { get; set; }

        public int TraveledDistance { get; set; }

        public void Drive(int distance)
        {
            if (this.CarFuel - distance* this.CarConsumptionPerKM < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.CarFuel -= distance * this.CarConsumptionPerKM;
                this.TraveledDistance += distance;
            }
        }

        public override string ToString()
        {
            return $"{this.CarModel} {this.CarFuel:f2} {this.TraveledDistance}";
        }
    }
}
