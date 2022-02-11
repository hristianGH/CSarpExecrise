using System;
using System.Collections.Generic;

namespace _3.CarConstructor
{
    
    class Program
    {  
        static void Main(string[] args)
        {
            
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();


            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                Tire[] tirearr = new Tire[4];
                string[] arr = input.Split(" ");
                for (int i = 0; i < 4; i ++)
                {
                    Tire tire = new Tire(int.Parse(arr[i+i]), double.Parse(arr[i+i + 1]));
                    tirearr[i] = tire;
                }
                tires.Add(tirearr);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                string[] arr = input.Split(" ");
                Engine engine = new Engine(int.Parse(arr[0]), double.Parse(arr[1]));
                engines.Add(engine);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] arr = input.Split(" ");
                int indexEngine = int.Parse(arr[5]);
                int indexTire = int.Parse(arr[6]);
                Car car = new Car(arr[0],arr[1],arr, engines[indexEngine], tires[indexTire]);
                cars.Add(car);
                input = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                if (item.Year>=2017)
                {
                    if (item.Engine.HorsePower>330)
                    {
                        if (item.TirePressure>8&&item.TirePressure<11)
                        {
                            Console.WriteLine($"Make: {item.Make}");
                            Console.WriteLine($"Model: {item.Model}");
                            Console.WriteLine($"Year: {item.Year}");
                            Console.WriteLine($"HorsePowers: {item.Engine.HorsePower}");
                            Console.WriteLine($"FuelQuantity: {item.FuelQuant}");

                        }
                    }
                }
            }
        }
    }
}
//{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
//Audi A5 2017 200 12 0 0
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int    Year { get; set; }
    public double FuelQuant { get; set; }
    public double FuelCons { get; set; }
    public Engine Engine { get; set; }
    public Tire[] Tires { get; set; }
    public double TirePressure { get; set; }

    public Car()
    {
        this.Make = "VW";
        this.Model = "Golf";
        this.Year = 2025;
        this.FuelQuant = 200;
        this.FuelCons = 10;
        Drive(2000);
    }
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public Car(string make, string model, string[] arr, Engine engine, Tire[] tires)
    {
        Make = make;
        Model = model;
        int year = int.Parse(arr[2]);
        Year = year;
        double fuelQ = double.Parse(arr[3]);
        FuelQuant = fuelQ;
        double fuelC = double.Parse(arr[4]);
        FuelCons = fuelC;
        FuelQuant -= FuelCons * 0.2;
        Engine = engine;
        Tires = tires;
        for (int i = 0; i < tires.Length; i++)
        {
            TirePressure += tires[i].Pressure;
        }
         

    }

    public Car(string make, string model, int year, double fuelQ, double fuelC)
    {
        Make = make;
        Model = model;
        Year = year;
        FuelQuant = fuelQ;
        FuelCons = fuelC;
    }
    public Car(string make, string model, int year, double fuelQ, double fuelC, Engine engine, Tire[] tires) 
    {
        Make = make;
        Model = model;
        Year = year;
        FuelQuant = fuelQ;
        FuelCons = fuelC;
        Engine = engine;
        Tires = tires;
    }
    private void Drive(double d)
    {
        double distance = FuelQuant - (d * FuelCons);
        if (distance > 0)
        {
            Console.WriteLine( FuelQuant -= distance);
        }
        else
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
    }
    public void WhoAmI()
    {
        Console.WriteLine($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: { this.FuelQuant:F2}L");

    }
}
public class Engine
{
    public int HorsePower { get; set; }
    public double CubicCapacity { get; set; }
    public Engine(int hp, double cc)
    {
        HorsePower = hp;
        CubicCapacity = cc;
    }
}
public class Tire
{
    public int Year { get; set; }
    public double Pressure { get; set; }
    public Tire(int year, double presure)
    {
        Year = year;
        Pressure = presure;
    }
}
