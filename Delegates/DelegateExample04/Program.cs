using System;

namespace DelegateExample04
{
    class Program
    {
        delegate int Operation(int number);

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Operation operation = Double;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = operation(arr[i]);
            }

            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }
        }

        private static int Double(int number)
        {
            return number * 2;
        }
    }
}
