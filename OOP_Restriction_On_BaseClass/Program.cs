using System;

namespace OOP_Restriction_On_BaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<Person> student = new Student<Person>("Jonh", 18, 5.70);
            student.PrintDetails();
        }
    }
}
