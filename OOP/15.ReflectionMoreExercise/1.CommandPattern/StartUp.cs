﻿namespace _1.CommandPattern
{
    using Core;
    using Core.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            
             ICommandInterpreter command = new CommandInterpreter();
             IEngine engine = new Engine(command);
             engine.Run();
        }
         
    }
}
