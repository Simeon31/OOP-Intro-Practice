using System;

namespace DelegateExample01
{
    class Program
    {
        delegate double MathOperation(double x, double y);

        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter two numbers: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            MathOperation add = (a, b) => a + b;
            MathOperation subtract = (a, b) => a - b;
            MathOperation multiply = (a, b) => a * b;
            MathOperation divide = (a, b) => a / b;

            Console.WriteLine($"x + y {add(x, y)}");
            Console.WriteLine($"x - y {subtract(x, y)}");
            Console.WriteLine($"x * y {multiply(x, y)}");
            Console.WriteLine($"x / y {divide(x, y)}");
        }
    }
}
