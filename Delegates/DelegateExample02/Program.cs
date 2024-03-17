using System;

namespace DelegateExample02
{
    class Program
    {
        delegate void ArrayOperation(double[] arr);

        static void Main(string[] args)
        {
            double[] arr = { 2, 4, 6, 8, 10 };

            ArrayOperation print = a =>
            {
                Console.Write("[");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                    if (i < a.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");
            };

            ArrayOperation increment = a =>
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] += 1;
                }
            };

            ArrayOperation square = a =>
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] *= a[i];
                }
            };

            print(arr);
            increment(arr);
            print(arr);
            square(arr);
            print(arr);
        }
    }
}
