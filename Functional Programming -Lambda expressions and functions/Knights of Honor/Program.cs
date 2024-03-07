using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            Action<string> action = word => Console.WriteLine("Sir " + word);

            Array.ForEach(arr, action);
        }
    }
}
