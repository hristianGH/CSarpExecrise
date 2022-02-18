using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cars
{
    class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(int hp,double fuel)
        {
            Hp = hp;
            Fuel = fuel;
            FuelCons = 1.25;
        }
        public virtual double FuelCons { get; set; }
        public double Fuel { get; set; }
        public int Hp { get; set; }
        public virtual void Drive(double km)
        {
            Fuel = Fuel - (FuelCons*km);
        }

    }
}
//•	DefaultFuelConsumption – double 
//•	FuelConsumption – virtual double
//•	Fuel – double
//•	HorsePower – int
//•	virtual void Drive(double kilometers)
//o The Drive method should have a functionality to reduce the Fuel based on the travelled kilometers.
