using System;
using System.Collections.Generic;

namespace ObjectsComparison
{
    class Person : IComparable<Person>
    {
        private readonly List<Person> people;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Missing name!");
                }
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }
                age = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Missing city!");
                }
                city = value;
            }
        }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
            people = new List<Person>();
        }
        public int CompareTo(Person other)
        {
            int resultOfName = this.Name.CompareTo(other.Name);
            if (resultOfName != 0)
            {
                return resultOfName;
            }

            int resultOfAge = this.Age.CompareTo(other.Age);
            if (resultOfAge != 0)
            {
                return resultOfAge;
            }

            return this.City.CompareTo(other.City);
        }

    }
}
