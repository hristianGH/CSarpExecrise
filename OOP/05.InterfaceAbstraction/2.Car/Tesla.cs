using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Car
{
    class Tesla : IElectricCar
    {
        public Tesla(string model, string col, int bat)
        {
            Model = model;
            Color = col;
            Battery = bat;
        }
        public int Battery { get; set; }
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
            return $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries {Environment.NewLine}{Start()} {Environment.NewLine}{Stop()}";
        }
        //Red Tesla Model 3 with 2 Batteries
    }
}
