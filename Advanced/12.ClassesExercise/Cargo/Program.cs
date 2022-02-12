using System;

namespace _7.Cargo
{
    delegate Engine ToEngine(string[] arr);
    delegate Tire[] ToTire(string[] arr);
    delegate CarCargo ToCargo(string[] arr);
    //delegate Car ToCar(string[] arr);

    class Program
    {
        static void Main(string[] args)
        {
            
            ToEngine toEngine = (x) =>
            {
                int engineSpeed = int.Parse(x[1]);
                int enginePower = int.Parse(x[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                return engine;
            };
            ToCargo toCargo = x =>
            {
                int weight = int.Parse(x[3]);
                string type = x[4];
                CarCargo cargo = new CarCargo(weight, type);
                return cargo;
            };
            ToTire toTire = (x) =>
            {
                Tire[] tires = new Tire[4];
                tires[0] = new Tire(double.Parse(x[5]), int.Parse(x[6]));
                tires[1] = new Tire( double.Parse(x[7]), int.Parse(x[8]));
                tires[2] = new Tire(double.Parse(x[9]), int.Parse(x[10]));
                tires[3] = new Tire(double.Parse(x[11]), int.Parse(x[12]));
                return tires;
            };
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                cars[i] = new Car(input[0],toEngine(input),toTire(input),toCargo(input));

            }
            string cargo = Console.ReadLine();
            foreach (var item in cars)
            {
                if (item.Cargo.CargoType=="fragile"&&cargo== "fragile")
                {
                    for (int i = 0; i < item.Tires.Length-1; i++)
                    {
                        if (item.Tires[i].TirePressure<1)
                        {
                            Console.WriteLine(item.Model);
                            break;
                        }
                         
                    }
                }
                else if (item.Cargo.CargoType == "flamable" && cargo == "flamable")
                {
                    if (item.Engine.EnginePower>250)
                    {
                        Console.WriteLine(item.Model);
                        
                    }
                }
            }
        }
    }
}
class Car
{
    public Car(string model,Engine engine, Tire[] tires, CarCargo cargo )
    {
        Model = model;
        Engine = engine;
        Tires = tires;
        Cargo = cargo;
    }
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Tire[] Tires  { get; set; }
    public CarCargo  Cargo { get; set; }
}
class Tire
{
    public Tire(double pressure,int age)
    {
        TirePressure = pressure;
        TireAge = age;
    }
    public double TirePressure { get; set; }
    public int TireAge { get; set; }
}
class Engine
{
    public Engine(int speed,int power)
    {
        EngineSpeed = speed;
        EnginePower = power;
    }
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
}
class CarCargo
{
    public CarCargo(int weight,string type)
    {
        CargoWeight = weight;
        CargoType = type;
    }
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
}
