using System;
using System.Collections.Generic;

namespace Name_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Predicate<string> predicate = word => word.Length <= n;

            string[] names = Console.ReadLine().Split();

            foreach (string name in names)
            {
                if (predicate(name) == true)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
