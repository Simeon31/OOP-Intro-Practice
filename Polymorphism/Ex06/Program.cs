using System;

namespace Polymorphism_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.GetInfo();

            BClass b = new BClass();
            b.GetInfo();
            Console.WriteLine("\nPress Enter Key to Exit...");
            Console.ReadLine();
        }
    }
}
