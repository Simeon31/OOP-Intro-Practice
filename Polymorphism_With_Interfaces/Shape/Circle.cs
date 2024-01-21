using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size) { }

        public override void GetName()
        {
            Console.WriteLine(" Circle:");
        }
        
        public override void GetArea()
        {
            double area = Math.PI * size * size;

            Console.WriteLine(" Area = {0:F2}", area);
        }

    }
}
