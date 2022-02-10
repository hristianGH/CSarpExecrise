using System;

namespace _8.CreatingSortFunc
{
    class Program
    {
        public delegate void SortDelegate(string[] x);
        static void Main(string[] args)
        {
            SortDelegate sort = x =>
            {
                int index = 0;
                int indexOdd = 0;
                int smallest = int.MaxValue;
                int smallestOdd = int.MaxValue;
                foreach (var item in x)
                {
                    int current = int.Parse(item);
                    if (current < smallest && current % 2 == 0)
                    {
                        index++;
                        smallest = current;
                    }
                    else if (current % 2 == 0)
                    {
                        index++;
                    }
                    if (current < smallestOdd && current % 2 != 0)
                    {
                        indexOdd++;
                        smallestOdd = current;
                    }
                    else if (current % 2 != 0)
                    {
                        indexOdd++;
                    }

                }

                string[] sorted = new string[x.Length];
                sorted[0] = smallest.ToString();
                for (int i = 1; i < index; i++)
                {
                    smallest = int.MaxValue;
                    foreach (var item in x)
                    {
                        int current = int.Parse(item);
                        if (current < smallest && current % 2 == 0 && int.Parse(sorted[i-1]) < current)
                        {
                            smallest = current;

                        }
                    }
                    sorted[i] = smallest.ToString();
                }
                sorted[index] = smallestOdd.ToString();

                for (int i = index+1; i < sorted.Length; i++)
                {
                    smallestOdd = int.MaxValue;
                    foreach (var item in x)
                    {
                        int current = int.Parse(item);
                        if (current < smallestOdd && current % 2 != 0 && int.Parse(sorted[i - 1]) < current)
                        {
                            smallestOdd = current;
                        }
                    }
                    sorted[i] = smallestOdd.ToString();
                }
                Console.WriteLine(string.Join(" ",sorted));
            };
            sort(Console.ReadLine().Split());
        }
    }
}
//20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 0