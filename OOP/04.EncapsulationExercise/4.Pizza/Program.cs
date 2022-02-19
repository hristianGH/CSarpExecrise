using System;
using System.Collections.Generic;

namespace _4.Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string pizzaName = input[1];

            input = Console.ReadLine().Split();
            Dough dough = new Dough(input[1], input[2], int.Parse(input[3]));
           // Console.WriteLine($"{dough.CalorieCalc():f2}");
            var list = new List<Toppings>();
            input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                var topping = new Toppings(input[1], int.Parse(input[2]));
                list.Add(topping);
                input = Console.ReadLine().Split();
              //  Console.WriteLine($"{topping.CalorieCalc():f2}");
            }
            Pizza pizza = new Pizza(pizzaName, dough, list.ToArray());
            Console.WriteLine($"{pizza.Name} - {pizza.CalCalc():f2} Calories.");
        }
    }
}
