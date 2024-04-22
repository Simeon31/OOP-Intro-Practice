using System;

namespace ExceptionHandlingExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            int result = 0;

            Console.Write("Enter first number: ");
            num01 = int.Parse(Console.ReadLine());


            Console.Write("Enter second number: ");
            num02 = int.Parse(Console.ReadLine());

            try
            {
                result = num01 / num02;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
