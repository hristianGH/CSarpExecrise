using System;

namespace _3.CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(", ");
           inp[0]= inp[0].Replace("Push ", "");
            var stack =new MyStack(inp);
            inp = Console.ReadLine().Split();
            while (inp[0]!="END")
            {
                if (inp[0]=="Pop")
                {
                    stack.Pop();
                }
                inp = Console.ReadLine().Split();
                if (inp[0]=="Push")
                {
                    stack.Push(inp[1]);
                }
            }
            stack.Each();
          //  stack.Each();

        }
    }
}
