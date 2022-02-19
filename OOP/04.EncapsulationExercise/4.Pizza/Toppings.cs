using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pizza
{
    class Toppings
    {
        public Toppings(string type, int wgt)
        {
            Type = type;
            Weight = wgt;
        }
        private string type;
        private int weight;
        private double calories;
        public string Type
        {
            get => type; set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                else
                {
                    type = value;
                }
            }
        }
        public int Weight
        {
            get => weight; set
            {
                if (value > 0 && value < 51)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                    
                }
            }
        }
        public double Calories { get; set; }
        public double CalorieCalc()
        {
            double toppingCal = 0;
            if (type.ToLower() == "meat")
            {
                toppingCal = 1.2;
            }
            else if (type.ToLower() == "veggies")
            {
                toppingCal = 0.8;

            }
            else if (type.ToLower() == "cheese")
            {
                toppingCal = 1.1;

            }
            else
            {
                toppingCal = 0.9;

            }
            double sum =2*( weight * toppingCal);
            return sum;
        }
    }
}
//•	Meat - 1.2;
//•	Veggies - 0.8;
//•	Cheese - 1.1;
//•	Sauce - 0.9;
//•	"[Topping type name] weight should be in the range [1..50]."