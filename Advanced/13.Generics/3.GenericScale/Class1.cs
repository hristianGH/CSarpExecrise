using System;
using System.Collections.Generic;
using System.Text;

namespace _3.GenericScale
{
    public class EqualityScale <T1, T2>
         where T1 : IComparable
         where T2 : IComparable
    {
        public  bool Compare(T1 t1, T2 t2)
        {
            int res = t1.CompareTo(t2);
            if (res>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
