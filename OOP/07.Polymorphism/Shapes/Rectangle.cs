namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double hei, double wid)
        {
            height = hei;
            width = wid;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (height + width);
        }
        public override string Draw()
        {
            return base.Draw()+"Rectangle";
        }
    }
}
