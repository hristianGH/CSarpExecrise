using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class BoxOfT<T>:IEnumerable<T>
    {
        public BoxOfT()
        {
            Count = 0;
        }

        public void Add(T value)
        {
            var curr = new Node<T>(value);
            if (Last == null)
            {
                curr.Index = 0;
                First = curr;
                Last = curr;
            }
            else
            {
                curr.Index++;
                Last.Next = curr;
                Last = curr;
            }
        }
        public void Remove()
        {
            Node<T> curr = First;
            while (curr.Next!=null)
            {

            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = First;
            while (curr!=null)
            {
                yield return curr.Value;
                curr = curr.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
         

        public int Count { get; set; }
        public Node<T> Last { get; set; }
        public Node<T> First { get; set; }
    }
}
public class Node<T>
{
    public Node(T value)
    {
        Value = value;
    }
    public Node<T> Next { get; set; }
    public T Value { get; set; }
    public int Index { get;  set; }

}
