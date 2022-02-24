using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{

    public enum ReportLevel
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Critical = 3,
        Fatal = 4
    }

}
//Info > Warning > Error > Critical > Fatal