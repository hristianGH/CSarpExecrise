using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAgeSort
{
    class Person
    {
        public Person(string n,int a)
        {
            Name = n;
            Age = a;
        }
        public Person(string n, int a,double w) :this(n,a)
        {
            Wage = w;
        }
        public String Name { get;private set; }
        public int Age { get;private set; }
        public double Wage { get;private set; }
        public void WageInc(double perC)
        {
            perC = 0.01 * perC;
            Wage = Wage * perC;
        }
        public override string ToString()
        {
            return $"{Name} is {Age} years old.";
            //return $"{Name} receives {Wage:f2}";
        }
        //Asen Ivanov receives 2640.00 leva.
    }
}
