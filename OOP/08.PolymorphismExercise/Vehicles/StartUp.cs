using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
        }
        static void ExerciseOneExtencion()
        {
            CarTwo car = new CarTwo();
            TruckTwo truck = new TruckTwo();
            Bus bus = new Bus();

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToUpper() == "CAR")
                {
                    car = new CarTwo(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                }
                else if (input[0].ToUpper() == "BUS")
                {
                    bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

                }
                else
                {
                    truck = new TruckTwo(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

                }
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[1].ToUpper() == "CAR")
                {
                    if (input[0].ToUpper() == "DRIVE")
                    {
                        car.Drive(double.Parse(input[2]));
                    }
                    else if (input[0].ToUpper() == "REFUEL")
                    {
                        car.Refuel((double.Parse(input[2])));
                    }
                }
                else if (input[1].ToUpper() == "BUS")
                {
                    if (input[0].ToUpper() == "DRIVE")
                    {
                        bus.Drive(double.Parse(input[2]));
                    }
                    else if (input[0].ToUpper() == "DRIVEEMPTY")
                    {
                        bus.DriveEmpty(double.Parse(input[2]));
                    }
                    else if (input[0].ToUpper() == "REFUEL")
                    {
                        bus.Refuel((double.Parse(input[2])));
                    }
                }
                else
                {
                    if (input[0].ToUpper() == "DRIVE")
                    {
                        truck.Drive(double.Parse(input[2]));
                    }
                    else if (input[0].ToUpper() == "REFUEL")
                    {
                        truck.Refuel((double.Parse(input[2])));
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

        }
        static void ExerciseOne()
        {
            Car car = new Car();
            Truck truck = new Truck();

            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToUpper() == "CAR")
                {
                    car = new Car(double.Parse(input[1]), double.Parse(input[2]));
                }
                else
                {
                    truck = new Truck(double.Parse(input[1]), double.Parse(input[2]));

                }
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToUpper() == "DRIVE")
                {
                    if (input[1].ToUpper() == "CAR")
                    {
                        car.Drive(double.Parse(input[2]));
                    }
                    else
                    {
                        truck.Drive(double.Parse(input[2]));
                    }
                }
                else
                {
                    if (input[1].ToUpper() == "CAR")
                    {
                        car.Refuel(double.Parse(input[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(input[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
