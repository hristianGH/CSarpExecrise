using System;

namespace _7.TurpleThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            arr[0] = arr[0] + " " + arr[1];
            if (arr.Length>4)
            {
            arr[3] = arr[3] + " " + arr[4];

            }
            (string, string, string) one = (arr[0], arr[2], arr[3]);
            arr = Console.ReadLine().Split();
            if (arr[2] == "drunk")
            {
                arr[2] = "True";
            }
            else
            {
                arr[2] = "False";
            }
            (string, int, string) two = (arr[0], int.Parse(arr[1]), arr[2]);
            arr = Console.ReadLine().Split();
            (string, double, string) three = (arr[0], double.Parse(arr[1]), arr[2]);
            Console.WriteLine($"{one.Item1} -> {one.Item2} -> {one.Item3}");
            Console.WriteLine($"{two.Item1} -> {two.Item2} -> {two.Item3}");
            Console.WriteLine($"{three.Item1} -> {three.Item2} -> {three.Item3}");




        }
    }
}
