using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pizza
{
    class Pizza
    {
        public Pizza(string name,Dough dough,Toppings[] toppings)
        {
            Name = name;
            Dough = dough;
            Topping = toppings;
            
        }
        string name;
        int toppingN;
        public string Name
        {
            get => name; set
            {
                if (value.Length > 15 && value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public Toppings[] Topping { get; set; }
        public int ToppingNumber
        {
            get => toppingN; set
            {
                int num = Topping.Length;
                if (num < 0 && num > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                else
                {
                    toppingN = num;
                }
            }
        }
        public double TotalCal { get; set; }
        public Dough Dough { get; set; }
        public double CalCalc()
        {
            double sum = 0; 
            foreach (var item in Topping)
            {
                sum += item.CalorieCalc();
            }
            sum += Dough.CalorieCalc();
            TotalCal = sum;
            return sum;
        }
    }
}
