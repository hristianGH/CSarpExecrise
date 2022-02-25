using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    interface ILogger
    {
        public IAppender[] Appenders { get; set; }
        void Error(string date, string messege);
        void Info(string date, string messege);
        void Warning(string date, string messege);
        void Critical(string date, string messege);
        void Fatal(string date, string messege);

        // Info > Warning > Error > Critical > Fatal
    }
}
