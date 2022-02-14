using System;

namespace _6.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            TrupleList<MyTuple<string,string>> list = new TrupleList<MyTuple<string,string>>();
            MyTuple<string, string> one = new MyTuple<string, string>(Console.ReadLine().Split());
            MyTuple<string, string> two = new MyTuple<string, string>(Console.ReadLine().Split());
            MyTuple<string, string> three = new MyTuple<string, string>(Console.ReadLine().Split());
            list.Items[0] = one;
            list.Items[1] = two;
            list.Items[2] = three;
            foreach (var item in list.Items)
            {
                Console.WriteLine(item.ItemOne+" -> "+item.ItemTwo);
            }
            

        }
    }
}
class MyTuple<T, T1>
{
    public MyTuple(string[] arr)
    {
        if (arr.Length > 2)
        {
            string name = arr[0];
            string fName = arr[1];
            string city = arr[2];
            name = name + " " + fName;
            ItemOne = new Tuple<T>((T)Convert.ChangeType(name, typeof(T)));
            ItemTwo = new Tuple<T1>((T1)Convert.ChangeType(city, typeof(T1)));
        }
        else
        {

            string one = arr[0];
            string two = arr[1];
            ItemOne = new Tuple<T>((T)Convert.ChangeType(one, typeof(T)));
            ItemTwo = new Tuple<T1>((T1)Convert.ChangeType(two, typeof(T1)));
        }
    }
     
    public Tuple<T> ItemOne { get; set; }
    public Tuple<T1> ItemTwo { get; set; }
}
class TrupleList<T>
{
    public TrupleList()
    {
        Items = new T[3];

    }
    public T[] Items { get; set; }

}
