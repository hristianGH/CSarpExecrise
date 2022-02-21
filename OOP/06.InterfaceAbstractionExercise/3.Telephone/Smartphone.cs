using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Telephone
{
    class Smartphone : IPhone
    {

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        public void Browse(string site)
        {
            Console.WriteLine($"Browsing: {site}!");
        }
        
    }
}
