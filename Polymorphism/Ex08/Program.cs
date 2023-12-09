using System;

namespace Polymorphism_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(10);
            int area = s.Area();

            Console.WriteLine("Area is: {0}", area);
            Console.ReadLine();
        }
    }
}
