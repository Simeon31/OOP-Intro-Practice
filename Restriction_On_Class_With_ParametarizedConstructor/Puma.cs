using System;
using System.Collections.Generic;
using System.Text;

namespace Restriction_On_Class_With_ParametarizedConstructor
{
    class Puma<T>: Cats where T: Cats
    {
        public string name;
        public Puma(string name, string typeOfCat, int age, char gender) : base()
        {
            this.name = name;
            this.typeOfCat = typeOfCat;
            this.age = age;
            this.gender = gender;
        }

        public override void Characteristics()
        {
            Console.WriteLine($"{name}, {typeOfCat}, {age}, {gender}");
        }
    }
}

