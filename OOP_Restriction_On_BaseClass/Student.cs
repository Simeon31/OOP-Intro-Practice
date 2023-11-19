using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Restriction_On_BaseClass
{
    public class Student<T> : Person where T  : Person 
    {
        public double grade;
        public Student(string name, int age, double grade) : base(name, age)
        {
            this.grade = grade;
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"\n Name:{name}\n Age:{age}\n Grade:{grade}");
        }
    }
}
