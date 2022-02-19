using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonTeam
{
   public class Team
    {
        public Team(string n)
        {
            Name = n;
            People = new List<Person>();
        }
        public string Name { get;private set; }
        public List<Person> People { get; private set; }
        public int CountMembers { get; private set; }
        public void AddMember(Person person)
        {
            People.Add(person);
            CountMembers = People.Count;
        }
    }
}
