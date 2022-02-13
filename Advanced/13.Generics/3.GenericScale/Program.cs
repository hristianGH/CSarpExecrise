using System;

namespace _3.GenericScale
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int, int> equality = new EqualityScale<int, int>();
            equality.Compare(15, 6);
        }
 
    }
}
