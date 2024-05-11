using System;

namespace Ex08_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    class Program
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number {i + 1} in the range [{start}...{end}]:");
                try
                {
                    numbers[i] = ReadNumber(start, end);
                    start = numbers[i];
                }
                catch (InvalidNumberException e)
                {
                    Console.WriteLine(e.Message);
                    i--; // repeat current iteration.
                }
            }

            Console.WriteLine("The numbers are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new InvalidNumberException($"The number is not in the range [{start}...{end}]");
            }

            return number;
        }
    }

    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message)
        {
        }
    }
}
