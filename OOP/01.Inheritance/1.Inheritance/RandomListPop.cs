using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Inheritance
{
    class RandomListPop
    {
        public RandomListPop()
        {
            List = new List<string>();
        }
        public List<string> List { get; set; }
        public string RandomString()
        {
            Random rnd = new Random();
           int nxt= rnd.Next(0, List.Count - 1);
            string rt = List[nxt];
           List.RemoveAt(nxt);
            return rt;
        }
    }
}
