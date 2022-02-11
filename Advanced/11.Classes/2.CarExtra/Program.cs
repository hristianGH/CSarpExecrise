using System;

namespace _2.CarExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
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
    public Car(string[] arr)
    {
        int year = int.Parse(arr[2]);
        string make = arr[1];
        string model = arr[0];
        make = this.make;
        model = this.model;
        year = this.year;
    }
}