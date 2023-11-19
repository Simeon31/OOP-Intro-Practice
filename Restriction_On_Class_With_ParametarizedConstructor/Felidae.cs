using System;
using System.Collections.Generic;
using System.Text;

namespace Restriction_On_Class_With_ParametarizedConstructor
{
    class Felidae
    {
        public int age;
        public char gender;

        public virtual void Characteristics()
        {
            Console.WriteLine($"{age}, { gender}");
        }
    }
}
