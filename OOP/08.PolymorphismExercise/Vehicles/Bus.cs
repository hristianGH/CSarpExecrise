using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : IVehicleTwo
    {
        public Bus()
        {

        }
        public Bus(double fuelQ, double fuelCons, double tankMAx)
        {
            if (fuelQ >= 0 && fuelQ <= tankMAx)
            {
                FuelQuantity = fuelQ;
            }
            else
            {
                FuelQuantity = 0;
            }

            FuelConsumption = fuelCons;

            TankCapacity = tankMAx;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public void Drive(double distance)
        {

            if (FuelQuantity - ((FuelConsumption + 1.4) * distance) >= 0)
            {
                FuelQuantity -= (FuelConsumption+1.4) * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public void DriveEmpty(double distance)
        {
            if (FuelQuantity - (FuelConsumption * distance) >= 0)
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
