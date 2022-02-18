using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Resturant
{
    class Food:Product
    {
        public Food(string name,double price,double grams):base(name,price)
        {
            Grams = grams;
        }
        public double Grams { get; set; }
    }
    class MiniDish:Food
    {
        public MiniDish(string name, double price, double grams):base(name, price, grams)
        {

        }
    }
    class Desert:Food
    {
        public Desert(string name, double price, double grams,double cal) :base(name,price,grams)
        {
            Calories = cal;
        }
         
        public double Calories { get; set; }
    }
    class Starter:Food
    {
        public Starter( string name, double price, double grams ):base(name,price,grams)
        {

        }
    }
}
