using System;
using System.Collections.Generic;
using System.Linq;

namespace Turn_around_and_perform
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int devisor = int.Parse(Console.ReadLine());

            Predicate<int> numberToBeRemoved = number => number % devisor == 0;

            numbers.RemoveAll(numberToBeRemoved);
            numbers.Reverse();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
