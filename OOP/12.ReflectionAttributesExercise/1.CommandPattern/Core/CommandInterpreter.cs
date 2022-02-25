using _1.CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.CommandPattern.Core
{
    class CommandInterpreter : Contracts.ICommandInterpreter
    {
        public string Read(string args)
        {
            string command=args.Split(" ",StringSplitOptions.RemoveEmptyEntries)[0]+="Command";
            string[] arr = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            arr[0] = command;
            string joined = string.Join(" ", arr);
            return joined;

        }
        

        
    }
}
