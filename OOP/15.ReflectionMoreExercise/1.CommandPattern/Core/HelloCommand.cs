using System;
using System.Collections.Generic;
using System.Text;

namespace _1.CommandPattern.Core
{
    public class HelloCommand : Contracts.ICommand
    {
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
