using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    public abstract class Animal
    {
        public Animal(string name, string favFood)
        {
            this.name = name;
            this.favouriteFood = favFood;
        }
        internal string name;
        internal string favouriteFood;
        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovorite food is {favouriteFood}";
        }

    }
    class Dog : Animal
    {
        public Dog(string name, string favFood) : base(name, favFood)
        {

        }
        public override string ExplainSelf()
        {
            return $"I am {name} and my fovorite food is {favouriteFood}{Environment.NewLine}DJAAF";
        }
    }
    //I am Pesho and my fovourite food is Whiskas
    //MEEOW
    //I am Gosho and my fovourite food is Meat
    //DJAAF

    class Cat : Animal
    {
        public Cat(string name, string favFood) : base(name, favFood)
        {

        }
        public override string ExplainSelf()
        {
            return $"I am {name} and my fovorite food is {favouriteFood}{Environment.NewLine}MEEOW";
        }
    }
}
