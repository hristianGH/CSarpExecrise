using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    class Box<T>
    {
        public Box()
        {
            Stack<T> Item = new Stack<T>();
            Items = Item;
        }
        public void Add(T element)
        {
            Items.Push(element);
        }
        public T Remove()
        {
            return Items.Pop();
        }
        public int Count { get; }
        public Stack<T> Items { get; set; }
    }
}
