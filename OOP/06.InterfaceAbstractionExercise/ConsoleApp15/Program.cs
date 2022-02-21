using System;

namespace PersonAndCitrizen
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            Interfaces.IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            Interfaces.IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.ID);
            Console.WriteLine(birthable.BirthDate);

        }
    }
}
