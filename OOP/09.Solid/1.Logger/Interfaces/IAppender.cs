using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    interface IAppender
    {
        public List<string> Appended { get; set; }
        public ILayout Layout { get; set; }
        void Appender(string app);
        public ReportLevel ReportLevel { get; set; }
    }
}
