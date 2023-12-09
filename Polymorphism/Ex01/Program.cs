using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
    class Calculate
    {
        int sum = 0;
        public void AddNumbers(int a, int b)
        {
            sum = a + b;
            Console.WriteLine("a + b = {0}", sum);
        }
        public void AddNumbers(int a, int b, int c)
        {
            sum = a + b + c;
            Console.WriteLine("a + b + c = {0}", sum);
        }
    }
}
