using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger
{
    interface ILayout
    {
         string Layout { get; set; }
        void LayoutSet();
    }
}
