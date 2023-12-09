using System;

namespace Polymorphism_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show();

            Console.ReadKey();
        }
    }
}
