using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size) { }

        public override void GetName()
        {
            Console.WriteLine(" Triangle:");
        }
        public override void GetArea()
        {
            double square = (size *size * Math.Sqrt(3)) / 4;

            Console.WriteLine(" Area = {0:F2}", square);
        }
    }
}
