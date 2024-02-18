using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> group01 = new SortedSet<Person>(new PersonNameComparator());
            SortedSet<Person> group02 = new SortedSet<Person>(new PersonAgeComparator());

            int n = int.Parse(Console.ReadLine());
     
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string name = arr[0];
                int age = int.Parse(arr[1]);
               
                group01.Add(new Person(name, age));
                group02.Add(new Person(name, age));
            }
         
            foreach (Person person in group01)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            foreach (Person person in group02)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
