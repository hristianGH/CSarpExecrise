using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1.BoxOfGeneric
{
    public class Box<T> : IEnumerable<T>
    {
        public Box(int range)
        {
            Value = new T[range];
        }
        public T[] Value { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Value)
            {
                if (item!=null)
                {
                    yield return item;
                }
                else
                {
                    break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
