using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            Appenders = appenders;
        }
        public IAppender[] Appenders { get; set; }

        public void Critical(string date, string messege)
        {
            string error = $"{date} - Critical - {messege}";
            foreach (var item in Appenders)
            {
                if (item.ReportLevel <= ReportLevel.Critical)
                {
                    item.Appender(error);
                }
            }
        }

        public void Error(string date, string messege)
        {
            string error = $"{date} - Error - {messege}";
            foreach (var item in Appenders)
            {
                if (item.ReportLevel <= ReportLevel.Error)
                {
                    item.Appender(error);
                }
            }
        }

        public void Fatal(string date, string messege)
        {
            string error = $"{date} - Fatal - {messege}";
            foreach (var item in Appenders)
            {
                if (item.ReportLevel <= ReportLevel.Fatal)
                {
                    item.Appender(error);
                }
            }
        }

        public void Info(string date, string messege)
        {
            string error = $"{date} - Info - {messege}";
            foreach (var item in Appenders)
            {
                if (item.ReportLevel <= ReportLevel.Info)
                {
                    item.Appender(error);
                }
            }
        }

        public void Warning(string date, string messege)
        {
            string error = $"{date} - Warning - {messege}";
            foreach (var item in Appenders)
            {
                if (item.ReportLevel <= ReportLevel.Warning)
                {
                    item.Appender(error);
                }
            }
        }
    }
}
