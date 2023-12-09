using System;

namespace Polymorphism_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Rectangle r3 = new Rectangle();
            int area = 0;

            r1.SetLength(2);
            r1.SetBreadth(3);
            r1.SetHeight(4);

            r2.SetLength(2);
            r2.SetBreadth(3);
            r2.SetHeight(4);

            area = r1.GetArea();
            Console.WriteLine("Area of r1: {0}", area);

            area = r2.GetArea();
            Console.WriteLine("Area of r2: {0}", area);

            r3 = r1 + r2;
            area = r3.GetArea();
            Console.WriteLine("Area of r3: {0}", area);
            Console.ReadKey();
        }
    }
}
