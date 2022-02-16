using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CustomStack
{
    class MyStack
    {
        public MyStack(params string[] ar)
        {
            var node = new Node(ar[0]);
            First = node;
            node.Index = 0;
            if (ar.Length > 0)
            {
                for (int i = 1; i < ar.Length; i++)
                {
                    var nodeNext = new Node(ar[i]);
                    node.Next = nodeNext;
                    node = node.Next;
                    node.Index = i;
                }
                Count = node.Index + 1;
            }
        }
        public Node First { get; set; }
        public int Count { get; private set; }
        public void Each()
        {
            if (First != null)
            {

                var curr = First;
                Console.WriteLine(curr.Value);
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    Console.WriteLine(curr.Value);
                }
            }
            else
            {
            }
        }
        public void Pop()
        {
            var curr = First;
            if (curr == null)
            {
                Console.WriteLine("No elements");
            }
            else if (curr.Next == null)
            {
                First = null;
            }
            else if (curr.Next.Next == null && curr.Next != null)
            {
                curr.Next = null;

            }
            else
            {

                while (curr.Next.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = null;
            }
            Count--;
        }
        public void Push(string val)
        {
            var node = new Node(val);

            if (First != null)
            {
                var curr = First;

                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = node;
                Count++;
            }
            else
            {
                First = node;
                Count++;
            }
        }
    }
    class Node
    {
        public Node(string value)
        {
            Value = value;
            Next = null;
        }
        public int Index { get; set; }
        public Node Next { get; set; }
        public string Value { get; set; }
    }
}
