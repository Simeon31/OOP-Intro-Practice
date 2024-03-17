using System;

namespace DelegateExample03
{
    class Program
    {
        delegate int Operation(int a, int b);

        static void Main(string[] args)
        {
            int[] arr01 = { 1, 2, 3, 4, 5 };
            int[] arr02  = { 6, 7, 8, 9, 10 };
            int[] result = new int[arr01.Length];

            Operation operation = Multiply;

            for (int i = 0; i < arr01.Length; i++)
            {
                result[i] = operation(arr01[i], arr02[i]);
            }

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
