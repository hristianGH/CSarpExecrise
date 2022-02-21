using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BorderControl
{
    class Robot :Keys.Iidentefiable
    {
        public Robot(string id, string name)
        {
            ID = id;
            Model = name;
        }
        public string ID { get; set; }
        public string Model { get; set; }
    }
}
