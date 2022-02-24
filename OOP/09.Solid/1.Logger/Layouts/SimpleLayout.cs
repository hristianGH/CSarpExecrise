using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    class SimpleLayout : ILayout
    {
        public SimpleLayout()
        {
            Layout = "{0} - {1} - {2}";
        }
        public string Layout{ get; set; }

        public void LayoutSet()
        {
            //Layout= "{0} - {1} - {2}";
        }
    }
}
