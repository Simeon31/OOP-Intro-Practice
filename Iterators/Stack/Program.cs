using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackImplementation<int> stack = new();
            string cmd = String.Empty;

            try
            {
                do
                {
                    string[] arr = cmd.Split();
                    string operation = arr[0];
                    switch (operation)
                    {
                        case "Push":

                            foreach (string item in arr.Skip(1))
                            {
                                stack.Push(int.Parse(item));
                            }

                            break;
                        case "Pop":

                            stack.Pop();
                            break;
                        case "Print":

                            foreach (int value in stack)
                            {
                                Console.WriteLine(value);
                            }
                            break;
                    }
                } while (!"END".Equals(cmd = Console.ReadLine()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
