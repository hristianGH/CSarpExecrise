using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ListIterator
{
    class MyList:IEnumerable<string>
    {
        public MyList()
        {
            Item = new List<string>();
        }
        public MyList(params string[] arr)
        {
            Item = new List<string>(arr);
            
        }

        public List<string> Item { get; set; }
        public int Index { get; private set; }
        public void Add(string ele)
        {
            Item.Add(ele);
        }
        public void Print()
        {
            Console.WriteLine(Item[Index]);
        }
        public bool Move()
        {
            if (Index +1 >Item.Count)
            {
                Console.WriteLine("Invalid Operation!");
                return false;
            }
            else
            {
                Index++;
                return true;
            }
        }
        public bool HasNext()
        {
            if (Index+1>Item.Count-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < Item.Count; i++)
            {
                yield return Item[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
     
}
