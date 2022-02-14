using System;

namespace _1.BoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BoxString<int> box = new BoxString<int>(n);
            for (int i = 0; i < n; i++)
            {
                box.Value[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{box} {box.Value[i]}");
            }
        }
    }

}

class BoxString<T>
{
    public BoxString(int n)
    {
        Value = new T[n];
    }
    public T[] Value { get; set; }
    public override string ToString()
    {
        return $"{Value.GetType()}:";
    }
}

