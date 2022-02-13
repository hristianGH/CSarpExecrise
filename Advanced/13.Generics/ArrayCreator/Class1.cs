using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCreator
{
   public class ArrayCreator
    {
        public static T[] Create<T>(int n,T input)
        {
            T[] arr = new T[n];
            for (int i = 0; i < n-1; i++)
            {
                arr[i] = input;
            }
            return arr;
        }
    }
}
