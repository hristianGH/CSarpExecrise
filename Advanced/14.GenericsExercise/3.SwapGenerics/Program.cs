using System;
using System.Collections.Generic;

namespace _3.SwapGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            Item<string> list = new Item<string>(n);
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            string[] input = Console.ReadLine().Split();
            list.Swap(int.Parse(input[0]), int.Parse(input[1]));

            foreach (var item in list.List)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
class Item<T>
{
    public Item(int n)
    {
        List = new List<T>(n+1);
    }
    public List<T> List { get; set; }
    public  void Swap(int indexO,int indexT)
    {
        if (List.Count>indexO &&List.Count>indexT)
        {
            string one = List[indexO].ToString();
            string two = List[indexT].ToString();
            List[indexO] = (T)Convert.ChangeType(two,typeof(T)) ;
            List[indexT] = (T)Convert.ChangeType(one, typeof(T));

        }
    }
    public void Add(T value)
    {
        List.Add(value);
    }
}
