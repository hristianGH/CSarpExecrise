using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PersonComparison
{
    public class Person:IComparable<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public Person(string[] arr)
        {
            Age = int.Parse(arr[1]);
            Name = arr[0];
            City = arr[2];
        }
      

        public int CompareTo(Person obj)
        {
            
            if (Name.CompareTo(obj.Name)!=0)
            {
                return Name.CompareTo(obj.Name);
            }
            else if (Age.CompareTo(obj.Age)!=0)
            {
                return Age.CompareTo(obj.Age);
            }
            else
            {
                return City.CompareTo(obj.City);
            }
        }
        public override string ToString()
        {
            return $"{Name} {Age} {City}";
        }
    }
    class ListPeople:IEnumerable
    {
        public ListPeople(string [] arr)
        {
            var peo = new Person(arr);
            People = new List<Person>();
            People.Add(peo);
        }
        public ListPeople()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void Add(string[] arr)
        {
            var peo = new Person(arr);
            People.Add(peo);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < People.Count; i++)
            {
                yield return People[i];
            }
        }
    }
}
