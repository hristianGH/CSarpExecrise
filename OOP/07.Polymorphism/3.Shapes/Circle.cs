using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        private double radius;
        public override double CalculateArea()
        {
            return (Math.PI * radius) * 2;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string Draw()
        {
            return base.Draw()+"Circle";
        }
    }
}
