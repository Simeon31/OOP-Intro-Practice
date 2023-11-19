using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Restriction_On_BaseClass
{
    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine(name + " " + age);
        }
    }
}
