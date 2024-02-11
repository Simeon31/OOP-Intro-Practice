using System;
using System.Collections.Generic;

namespace ObjectsComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            try
            {
                while (!"END".Equals(input = Console.ReadLine()))
                {
                    string[] personInfo = input.Split();
                    string name = personInfo[0];
                    int age = int.Parse(personInfo[1]);
                    string city = personInfo[2];
                    people.Add(new Person(name, age, city));
                }

                int n = int.Parse(Console.ReadLine());
                if (n < 1 || n > people.Count - 1)
                {
                    Console.WriteLine("No matches");
                    return;
                }

                Person person = people[n];
                int samePeopleCount = 0;
                int differentPeopleCount = 0;
                foreach (Person p in people)
                {
                    if (p.CompareTo(person) == 0)
                    {
                        samePeopleCount++;
                    }
                    else
                    {
                        differentPeopleCount++;
                    }
                }

                Console.WriteLine($"{samePeopleCount} {differentPeopleCount} {people.Count}");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
