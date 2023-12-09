using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Ex08
{
    class Square : Shape
    {
        private int side;

        public Square(int a)
        {
            a = 0;
            side = a;
        }

        public override int Area()
        {
            Console.WriteLine("Sqaure area is: ");
            return (side * side);
        }
    }
}
