using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cars
{
     class Motorcycle:Vehicle 
    {
        public Motorcycle(int hp,double fuel):base(hp,fuel)
        {

        }
    }
    class RaceMotor:Motorcycle
    {
        public RaceMotor(int hp , double fuel):base(hp,fuel)
        {
            this.FuelCons = 8;
        }
    }
    class CrossMotor:Motorcycle
    {
        public CrossMotor(int hp, double fuel) : base(hp, fuel)
        {

        }
    }
}
