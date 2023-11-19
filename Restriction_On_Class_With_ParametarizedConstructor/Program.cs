using System;

namespace Restriction_On_Class_With_ParametarizedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Puma<Cats> puma = new Puma<Cats>("Alex", "puma", 5, 'f');

            puma.Characteristics();
        }
    }
}
