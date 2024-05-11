using System;
using System.Collections.Generic;

namespace ExceptionHandlingExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int index = 10;

            try
            {
                Console.WriteLine("Number at index {0}: {1}", index, numbers[index]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: index was out of range.");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
