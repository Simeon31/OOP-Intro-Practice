using System;

namespace Polymorphism_Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Interest i = new Interest();
            double finalAmount = i.TrueBank(5000.00, 0.1);
            Console.WriteLine("Normal interest for a holder " + finalAmount);


            i = new SimpleInterest();
            finalAmount = i.TrueBank(5000.00, 0.1);
            Console.WriteLine("Simple interest for a holder " + finalAmount);


            i = new FixedInterest();
            finalAmount = i.TrueBank(5000.00, 0.1);
            Console.WriteLine("Fixed interest for a holder " + finalAmount);
        }
    }
}
