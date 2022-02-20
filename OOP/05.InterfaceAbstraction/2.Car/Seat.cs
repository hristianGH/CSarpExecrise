using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Car
{
    class Seat : ICar
    {
        public Seat(string model, string col)
        {
            Model = model;
            Color = col;

        }
        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            string messege = "Engine start";
            return messege;
        }

        public string Stop()
        {
            string messege = "Breaaak!";
            return messege;

        }
        public override string ToString()
        {
            return $"{Color} {this.GetType().Name} {Model} {Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
        }
    }
}
