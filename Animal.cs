using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction_And_Interfaces
{
    abstract class Animal : IMakeNoise, IMakeTrick
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return $"{name}";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter a name! ");
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Invalid age! ");
                }
                age = value;
            }
        }

        public virtual string MakeNoise()
        {
            return $"My name is {Name}{Environment.NewLine}I am {Age} years old.";
        }

        public virtual string MakeTrick()
        {
            return $"Look at my trick! ";
        }
    }
}
