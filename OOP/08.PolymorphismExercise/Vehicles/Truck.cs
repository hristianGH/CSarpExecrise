using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : IVehicle
    {
        public Truck()
        {

        }
        public Truck(double fuelQ, double fuelCons)
        {
            FuelQuantity = fuelQ;
            FuelConsumption = fuelCons + 1.6;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity - (FuelConsumption * distance) >= 0)
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double amount)
        {
            FuelQuantity += amount * 0.95;
        }
    }
    class TruckTwo : IVehicleTwo
    {
        public TruckTwo()
        {

        }
        public TruckTwo(double fuelQ, double fuelCons, double tankMAx)
        {
            if (fuelQ >= 0 && fuelQ <= tankMAx)
            {
                FuelQuantity = fuelQ;
            }
            else
            {
                FuelQuantity = 0;
            }

            FuelConsumption = fuelCons + 1.6;
            TankCapacity = tankMAx;

        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity - (FuelConsumption * distance) >= 0)
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {

                if (FuelQuantity + amount > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                }
                else
                {

                    FuelQuantity += amount;
                }
            }
        }
    }
}
