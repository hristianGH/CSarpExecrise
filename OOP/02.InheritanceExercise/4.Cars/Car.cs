using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cars
{
    class Car:Vehicle
    {
        public Car(int hp , double fuel):base(hp,fuel)
        {
            this.FuelCons = 3;
        }
    }
    class SportCar:Car
    {
        public SportCar(int hp, double fuel) : base(hp, fuel)
        {
            this.FuelCons = 10;
        }
    }
}
