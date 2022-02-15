using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Library
{
    public class BookLibrary <T>  :IEnumerable<T>
         
    {
        public BookLibrary (params T[] items)
        {
           
            Items = items;
        }
        public BookLibrary()
        {

        }
         
        public   T[]  Items { get; private set; }

         

        public IEnumerator<T> GetEnumerator()
        {
            return new LibraryIterator<T>(Items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
