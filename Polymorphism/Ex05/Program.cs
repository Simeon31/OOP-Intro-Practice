using System;

namespace Polymorphism_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Interest i = new Interest();

            double finalAount = i.TrueBank(5000.00, 0.1);
            Console.WriteLine("Normal interest for a holder " + finalAount);

            finalAount = i.TrueBank(5000.00, 0.1, "prime");
            Console.WriteLine("Prime interest for a holder " + finalAount);
        }
    }
}
