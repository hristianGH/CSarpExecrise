using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    interface IVehicle
    {
          double FuelQuantity { get; set; }
          double FuelConsumption { get;   set; }
        public void Refuel(double amount);
        public void Drive(double distance);


    }
    interface IVehicleTwo 
    {
        double FuelQuantity { get; set; }
        double FuelConsumption { get; set; }
        double TankCapacity { get; set; }
        public void Refuel(double amount);
        public void Drive(double distance);
    }
}
//fuel quantity, fuel consumption in liters per km 
//driven a given distance 
//refueled with a given amount of fuel
