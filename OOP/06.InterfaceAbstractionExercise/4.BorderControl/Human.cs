using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BorderControl
{
    class Human : Keys.Iidentefiable, Keys.IBirthed, Keys.IPerson
    {
        public Human(string id, string name, int age, string bD)
        {
            ID = id;
            Name = name;
            Age = age;
            DateTime date = DateTime.ParseExact(bD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Birthdate = date;
            IsRebel = false;
            //dd/mm/yyyy
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsRebel { get ; set ; }
    }
    class Pet : Keys.IBirthed
    {
        public Pet(string n, string bD)
        {
            Name = n;
            DateTime date = DateTime.ParseExact(bD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Birthdate = date;
        }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }
    class Rebel : Keys.IPerson
    {

        public Rebel(string n, int a, string grp)
        {
            this.Name = n;
            this.Age = a;
            this.Group = grp;
            IsRebel = true;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public bool IsRebel { get; set; }

    }
}
//public Citizen(string n, int a, string id, string bD)
//{
//    Name = n;
//    Age = a;
//    ID = id;
//    DateTime date = DateTime.ParseExact(bD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
//    Birthdate = date;
//    //dd/mm/yyyy
//}
// public string Name { get; set; }
// public int Age { get; set; }
// public string ID { get; set; }
// public DateTime Birthdate { get; set; }
//    }
//    class Pet : IBirthed
// {
//    public Pet(string n, string bD)
//    {
//        Name = n;
//        DateTime date = DateTime.ParseExact(bD, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
//        Birthdate = date;
//    }
//    public string Name { get; set; }
//    public DateTime Birthdate { get; set; }