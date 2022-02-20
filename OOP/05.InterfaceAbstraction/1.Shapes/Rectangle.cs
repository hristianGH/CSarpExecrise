using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rectangle : IDrawable
    {
        public Rectangle(int wit, int hei)
        {
            Width = wit;
            Height = hei;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j <= Width; j++)
                {
                    if (i == 0 || i == Height - 1)
                    {
                        Console.Write("*");
                    }
                    else if (j == 0 || j == Width)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

