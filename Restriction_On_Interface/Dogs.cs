using System;
using System.Collections.Generic;
using System.Text;

namespace Restriction_On_Interface
{
    class Dogs<T> where T : IComparable
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Dogs(int age)
        {
            Age = age; 
        }
        public void GetDogsAge()
        {
            if (Age.CompareTo(1) == 0)
            {
                Console.WriteLine("Dog's age: puppy\n ");
            }
            else
            {
                Console.WriteLine("Dog's age: {0}", Age);
            }
        }
    }
}
