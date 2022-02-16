using System;

namespace _1.ListIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList();
            bool isCreated = false;
            string[] input = Console.ReadLine().Split();
            while (input[0].ToUpper() != "END")
            {
                if (input[0] == "Create" && isCreated == false)
                {
                    if (input.Length > 0)
                    {
                        for (int i = 1; i < input.Length; i++)
                        {
                            list.Add(input[i]);
                        }
                        isCreated = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation!");

                    }
                }
               else if   (input[0]=="Print")
                {
                    if (list.Item.Count>0)
                    {
                        list.Print();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation!");
                    }
                }
               else if (input[0]=="Move")
                {
                    list.Move();
                    Console.WriteLine(true);
                }
                else if (input[0]=="HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (input[0]=="PrintAll")
                {
                    Console.WriteLine(string.Join(" ",list));
                }
                input = Console.ReadLine().Split();
            }
        }
        
    }
}
