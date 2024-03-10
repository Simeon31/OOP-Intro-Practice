using System;
using System.Linq;

namespace User_comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(userNumbers, (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return x.CompareTo(y);
                }
            });

            Console.WriteLine(string.Join(" ", userNumbers));
        }
    }
}
