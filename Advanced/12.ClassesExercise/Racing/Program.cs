using System;

namespace _6.Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            var collection = new System.Collections.Generic.Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                double fuelA = double.Parse(input[1]);
                double fuelC = double.Parse(input[2]);
                Car car = new Car(input[0], fuelA, fuelC);
                collection.Add(input[0], car);

            }

            string inputTwo = Console.ReadLine();
            while (inputTwo != "End")
            {
                input = inputTwo.Split();
                double km = double.Parse(input[2]);
                if (input[0] == "Drive")
                {
                    foreach (var item in collection)
                    {
                        if (item.Key == input[1])
                        {
                            if (item.Value.FuelAmount - (km * item.Value.FuelConsPerKm) >= 0)
                            {
                                item.Value.FuelAmount -= km * item.Value.FuelConsPerKm;
                                item.Value.TravelDistance += km;
                            }
                            else
                            {
                                Console.WriteLine("Insufficient fuel for the drive");
                            }
                        }
                    }
                }
                inputTwo = Console.ReadLine();
            }
            foreach (var item in collection)
            {

                Console.WriteLine($"{item.Key} {item.Value.FuelAmount:f2} {item.Value.TravelDistance}");
            }
        }
    }
}
class Car
{
    public Car(string model, double fuelA, double fuelCo)
    {
        Model = model;
        FuelAmount = fuelA;
        FuelConsPerKm = fuelCo;
        TravelDistance = 0;
    }
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsPerKm { get; set; }
    public double TravelDistance { get; set; }


}