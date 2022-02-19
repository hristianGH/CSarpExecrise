using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pizza
{
    class Dough
    {
        public Dough(string fl, string tech, int wei)
        {
            Flour = fl;
            Technique = tech;
            Weight = wei;
        }
        private string flour;
        private string technique;
        private double calories;
        private int weight;

        public string Flour
        {
            get { return this.flour; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");

                }
                else
                {
                    flour = value;
                }
            }
        }
        public string Technique
        {
            get => this.technique;
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                {
                    technique = value;
                }
            }
        }
        public double Calories
        {
            get => this.calories; set
            {
                if (value > 0)
                {
                    calories = value;
                }
                else
                {
                    throw new ArgumentException("Cannot be negative");
                }
            }
        }
        public int Weight
        {
            get => this.weight; set
            {
                if (value > 0 && value < 201)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }
            }
        }
        public double CalorieCalc()
        {
            double flourCal;
            if (flour.ToLower() == "white")
            {
                flourCal = 1.5;
            }
            else
            {
                flourCal = 1;
            }
            double techCal;
            if (technique.ToLower() == "crispy")
            {
                techCal = 0.9;
            }
            else if (technique.ToLower() == "chewy")
            {
                techCal = 1.1;
            }
            else
            {
                techCal = 1.0;
            }
            double sum = (2 * weight) * flourCal * techCal;
            Calories = sum;
            return sum;
        }
    }
}
//flour type white or wholegrain
//baking technique crispy, chewy or homemade
//"Invalid type of dough."