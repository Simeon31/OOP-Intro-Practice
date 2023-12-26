using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction_And_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Rex", 3);
            Animal cat = new Cat("Lexi", 2);

            Console.WriteLine(dog.MakeNoise());
            Console.WriteLine(dog.MakeTrick());

            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick());

        }
    }
}
