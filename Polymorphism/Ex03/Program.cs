using System;

namespace Polymorphism_Ex03
{
    class Show
    {
        static void Main(string[] args)
        {
            Show show = new Show();

            show._Show(5);
            show._Show(500.2f);
            show._Show("Hello c#");
            Console.ReadKey();
        }
        void _Show(int i)
        {
            Console.WriteLine("The value of int is: {0}", i);
        }
        void _Show(float f)
        {
            Console.WriteLine("The value of float is {0}", f);
        }
        void _Show(string s)
        {
            Console.WriteLine("The vaue of string is: {0}", s);
        }
    }
}
