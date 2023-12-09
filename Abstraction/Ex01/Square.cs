using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Square : ColoredFigure
    {
        public Square(string color, double size) : base(color, size) { }

        public override void GetName()
        {
            Console.WriteLine(" Square:");
        }
        public override void GetArea()
        {
            double S = size * size;

            Console.WriteLine(" Area = {0:F2}", S);
        }

    }
}
