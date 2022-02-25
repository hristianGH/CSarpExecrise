using System;

namespace _1.Stealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string res = spy.StealFieldInfo("Hacker","username","password");
            Console.WriteLine(spy.CollectGettersAndSetters("Hacker"));
          
        }
    }
}
