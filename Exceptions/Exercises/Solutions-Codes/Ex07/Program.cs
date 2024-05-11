using System;

namespace Ex07_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            try
            {
                int n = int.Parse(Console.ReadLine());
                
                if (n < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                
                Console.WriteLine("The squre root of the number {0} is {1}", n, Math.Sqrt(n));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
