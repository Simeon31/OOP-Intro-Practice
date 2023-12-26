using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
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
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Rebel without a name");
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
                    throw new ArgumentException("Invalid age of a rebel");
                }
                age = value;
            }
        }

        public string Group
        {
            get { return group; }

            set
            {
                group = value;
            }
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
