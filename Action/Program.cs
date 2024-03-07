using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            Action<string> action = word => Console.WriteLine(word);

            Array.ForEach(arr, action);
        }
    }
}
