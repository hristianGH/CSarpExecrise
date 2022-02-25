using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    class ConsoleAppender:IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
            Appended = new List<string>();
            ReportLevel = 0;
        }
       
        public List<string> Appended { get; set; }
        public ILayout Layout { get; set; }
        public ReportLevel ReportLevel { get; set; }

        public void Appender(string app)
        {
            app = string.Format(Layout.Layout, app.Split(" - "));
            Console.WriteLine(app);
            
        }
    }
}
