using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1.Logger
{
    class FileAppender : IAppender
    {
        public FileAppender(ILayout layout, LogFile file)
        {
            Layout = layout;
            Appended = new List<string>();
            ReportLevel = 0;
        }
        public ILayout Layout { get; set; }
        public string File { get; set; }
        public List<string> Appended { get; set; }
        public ReportLevel ReportLevel { get; set; }

        public void Appender(string app)
        {
            app = string.Format(Layout.Layout, app.Split(" - "));
            Appended.Add(app);
        }
        public void Write()
        {
            StreamWriter writer = new StreamWriter("log.txt");
            foreach (var item in Appended)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
    }
}
//File.AppendAllText(Path, "blah");