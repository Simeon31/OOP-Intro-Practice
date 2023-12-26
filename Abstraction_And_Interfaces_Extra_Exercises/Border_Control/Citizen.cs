using System;
using System.Collections.Generic;

namespace Border_Control
{
    class Citizen : ICheckCitizen, IBuyer
    {
        private string name;
        private int age;
        private long id;
        private int food;

        public int Food
        {
            get { return food; }

            set
            {
                food = value;
            }
        }

        public string Name
        {
            get { return $"{name}"; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Citizen without a name");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age of a citizen");
                }
                age = value;
            }
        }

        public long ID
        {
            get { return id; }
            set
            {
                if (value.ToString().Length > 10)
                {
                    throw new ArgumentException("Invalid id of a citizen");
                }
                id = value;
            }
        }
        public Citizen(string name, int age, long id)
        {
            Name = name;
            Age = age;
            ID = id;
        }
        public void BuyFood()
        {
            Food += 10;
        }

        public void CheckForFalsifiedID(int id)
        {
            long lastThreeDigits = ID % 1000;
            int falsifiedDigit = (int)lastThreeDigits;

            Console.WriteLine();
            if (lastThreeDigits == id)
            {
                Console.WriteLine("{0} with ID: {1} does not pass", Name, ID);
                Console.WriteLine("Falsified number: {0}", falsifiedDigit);
            }
            else
            {
                Console.WriteLine("Citizen: {0} Pass", Name);
            }
        }

        public void CheckCitizen(Citizen citizen, int digitToCheck)
        {
            citizen.CheckForFalsifiedID(digitToCheck);
        }
    }
}
