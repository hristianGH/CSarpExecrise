using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Telephone
{
    class StationaryPhone : IPhone
    {
        public void Call(string num)
        {
            Console.WriteLine($"Dialing... {num}");

        }
    }
}
