using System;

namespace Restriction_On_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs<int> dog = new Dogs<int>(10);
            dog.GetDogsAge();

            Console.Write("Enter new dog's age: ");
            dog.Age = int.Parse(Console.ReadLine());
            dog.GetDogsAge();

        }
    }
}
