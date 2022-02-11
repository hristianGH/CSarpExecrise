using System;

namespace _0.Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Car
    {
        string make;
        string model;
        int year;
        double fuelConsumption;
        double fuelQuantity;
        public string Make
        {
            set => make = value;
        }
        public string Model { set => model = value; }
        public int Year
        {
            set => year = value;
            get => year;
        }
    }
}
