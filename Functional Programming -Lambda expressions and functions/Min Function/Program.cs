using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> func = x => int.Parse(x);

            int[] numbers = Console.ReadLine().Split().Select(func).ToArray();

            Console.WriteLine(numbers.Min());
        }
    }
}
