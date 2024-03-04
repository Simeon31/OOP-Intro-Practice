using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> subtract = x => x - 1;

            string operation = String.Empty;
            while (!"end".Equals(operation = Console.ReadLine()))
            {
                switch (operation)
                {
                    case "add":
                        listOfNumbers = listOfNumbers.Select(add).ToList();
                        break;
                    case "multiply":
                        listOfNumbers = listOfNumbers.Select(multiply).ToList();
                        break;
                    case "substract":
                        listOfNumbers = listOfNumbers.Select(subtract).ToList();
                        break;
                    case "print":
                        foreach (int number in listOfNumbers)
                        {
                            Console.Write(number + " ");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
