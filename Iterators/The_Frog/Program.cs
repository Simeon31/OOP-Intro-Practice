using System;
using System.Collections.Generic;
using System.Linq;

namespace Frog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stoneNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake(stoneNumbers);

            foreach (int stone in lake)
            {

                Console.Write($"{stone} ");
            }
            foreach (int stone in lake.Enumerator())
            {
                Console.Write($"{stone} "); 
            }
        }
    }
}
