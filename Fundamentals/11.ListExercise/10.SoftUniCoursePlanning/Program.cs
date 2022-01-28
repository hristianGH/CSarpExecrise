using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ")
                .ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] arg = input.Split(':');
                string command = arg[0];
                string lesson = arg[1];
                if (command == "Add")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (command =="Insert")
                {
                    int index = int.Parse(arg[2]);

                    if (!schedule.Contains(lesson))
                    {
                        schedule.Insert(index, lesson);
                    }
                }
                else if (command =="Remove")
                {
                    if (schedule.Contains(lesson))
                    {
                        schedule.Remove(lesson);
                    }
                }
                else if (command == "Swap")
                {
                    string otherLeson = arg[2];
                    int indexOfFirstLesson = schedule.IndexOf(lesson);
                    int indexOfSecondLesson = schedule.IndexOf(otherLeson);
                    if (schedule.Contains(lesson) && schedule.Contains(otherLeson))
                    { 
                        string temp = schedule[indexOfFirstLesson];
                        schedule[indexOfFirstLesson] = schedule[indexOfSecondLesson];
                        schedule[indexOfSecondLesson] = temp;
                    }

                    if (schedule.Contains(lesson +"-Exercise")
                        && schedule.Contains(schedule[indexOfFirstLesson]))
                    {
                        indexOfFirstLesson = schedule.IndexOf(lesson);
                        schedule.Remove(lesson + "-Exercise");
                        schedule.Insert(indexOfFirstLesson + 1, lesson + "-Exercise");
                    }
                    else if (schedule.Contains(otherLeson + "-Exercise") 
                        && schedule.Contains(schedule[indexOfSecondLesson]))
                    {
                        indexOfSecondLesson = schedule.IndexOf(otherLeson);
                        schedule.Remove(otherLeson + "-Exercise");
                        schedule.Insert(indexOfSecondLesson + 1, otherLeson + "-Exercise");
                    }
                }
                else if(command == "Exercise")
                {
                    string exercise = lesson + "-Exercise";
                    if (schedule.Contains(lesson) && !schedule.Contains(exercise))
                    {
                        int indexOfLesson = schedule.IndexOf(lesson);
                        schedule.Insert(indexOfLesson + 1, exercise);
                    }
                    else if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                        schedule.Add(exercise);
                    }
                }
            }

            for (int i = 1; i <= schedule.Count; i++)
            {
                Console.WriteLine($"{i}.{schedule[i - 1]}");
            }
        }
    }
}
