using System;
using System.Collections.Generic;
using System.Text;

namespace _1.CommandPattern.Core
{
    class Engine : Contracts.IEngine
    {
        public Engine(Contracts.ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        private Contracts.ICommandInterpreter commandInterpreter;
        public void Run()
        {
            string[] input = commandInterpreter.Read(Console.ReadLine()).Split();
            Invoke(input);

        }
        public void Invoke(string[] command)
        {
            string spaceName = typeof(CommandInterpreter).Namespace;
            var type = Type.GetType($"{spaceName}.{command[0]}");
            if (type != null)
            {

                var instance = (Contracts.ICommand)Activator.CreateInstance(type);
                command[0] = null;
                for (int i = 1; i < command.Length; i++)
                {
                    if (command[i] != null)
                    {
                        command[i - 1] = command[i];

                    }
                }
                string output = instance.Execute(command);
                Console.WriteLine(output);
            }
        }
    }
}
