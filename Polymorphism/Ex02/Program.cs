using System;

namespace Polymorphism_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Add(10, 20);
            obj.Add(10.5f, 20.5f);
            obj.Add("Praynaya", "Rout");
            Console.ReadKey();
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string str01, string str02)
        {
            Console.WriteLine(str01 + " " + str02);
        }
    }
}
