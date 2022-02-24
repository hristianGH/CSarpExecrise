using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    class XmlLayout : ILayout
    {
        public XmlLayout()
        {
            LayoutSet();
        }
        public string Layout { get; set; }

        public void LayoutSet()
        {
            Layout = "<log>@   <date>{0}</date>@   <level>{1}</level>@   <messege>{2}</messege>@</log>";
           Layout= Layout.Replace("@", Environment.NewLine);
        }
    }
}
