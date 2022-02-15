using System.Collections;
using System.Collections.Generic;

namespace _1.Library
{
    public class LibraryIterator<T> : IEnumerator<T>  
    {
        private T[] items;
        private int index=-1;
        public LibraryIterator(T[] items)
        {
            this.items = items;
             
        }

        public T Current => items[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            this.items = null;
        }

        public bool MoveNext()
        {
             index++;
            return index < items.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}