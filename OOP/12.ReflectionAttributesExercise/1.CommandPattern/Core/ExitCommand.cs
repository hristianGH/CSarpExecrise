using System;
using System.Collections.Generic;
using System.Text;

namespace _1.CommandPattern.Core
{
    class ExitCommand : Contracts.ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
