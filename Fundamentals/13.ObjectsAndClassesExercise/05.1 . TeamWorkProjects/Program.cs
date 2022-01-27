using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._1_._TeamWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());
            bool inTeam = false;
            List<Team> teams = new List<Team>();
            List<People> people = new List<People>();
            string inputEmpty = "";
            for (int i = 0; i < teamsToRegister; i++)
            {
                inputEmpty = Console.ReadLine();
                string[] input = inputEmpty.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string teamName = input[1];
                bool personNameExist = people.Select(x => x.PersonName).Contains(name);
                bool teamNameExist = teams.Select(x => x.TeamName).Contains(teamName);

                if (personNameExist == true)
                {
                    Console.WriteLine($"{name} cannot create another team");
                }
                else if (teamNameExist == true)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    People person = new People(name, inTeam = true);
                    people.Add(person);


                    Team team = new Team(teamName, name);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {name}!");
                }

            }
            inputEmpty = Console.ReadLine();
            while (inputEmpty != "end of assignment")
            {
                string[] inputTwo = inputEmpty.Split("->");
                string nameToJoin = inputTwo[0];
                string teamToJoin = inputTwo[1];
                int index = teams.FindIndex(x => x.TeamName == teamToJoin);

                bool creatorIsIn = people.Select(x => x.PersonName).Contains(nameToJoin);
                bool memberIsIn = teams.Select(x => x.Members).Any(x => x.Contains(nameToJoin));
                bool teamNonExistent = teams.Select(x => x.TeamName).Contains(teamToJoin);
                 if (creatorIsIn == true)
                {
                    Console.WriteLine($"Member {nameToJoin} cannot join team {teamToJoin}!");

                } //bool person;
                else if (teamNonExistent == false)
                {
                    Console.WriteLine($"Team { teamToJoin} does not exist!");

                }
               

                else if (memberIsIn == true)
                {
                    Console.WriteLine($"Member {nameToJoin} cannot join team {teamToJoin} !");
                }
                else
                {
                    teams[index].Members.Add(nameToJoin);
                }
                inputEmpty = Console.ReadLine();

            }
            Team[] toDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0).ToArray();
            Team[] toKeep = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).Where(x => x.Members.Count > 0).ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var item in toKeep)
            {
                sb.AppendLine($"{item.TeamName}");
                sb.AppendLine($"- {item.Creator}");
                foreach (var members in item.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {members}");
                }
            }
            sb.AppendLine("Teams to disband:");

            foreach (var disband in toDisband)
            {
                sb.AppendLine($"{disband.TeamName}");
            }
            Console.WriteLine(sb.ToString());
        }
    }

    class People
    {
        public People(string a, bool b)
        {
            PersonName = a;
            InTeam = b;
        }
        public string PersonName { get; set; }
        public bool InTeam { get; set; }
    }
    class Team
    {
        public Team(string a, string b)
        {
            TeamName = a;
            Creator = b;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
   
}
