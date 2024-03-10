using System;
using System.Linq;

namespace List_of_predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Predicate<int> predicate = number =>
            {
                foreach (int divisor in divisors)
                {
                    if (number % divisor != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            for (int i = 1; i <= n; i++)
            {
                if (predicate(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
