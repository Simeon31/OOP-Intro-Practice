using System;

namespace Border_Control
{
    public class HumanCredentials 
    {
        private string name;
        private int age;
        private long id;
        protected string Name
        {
            get
            {
                return $"{name}";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Citizen without a name");
                }
                name = value;
            }
        }
        protected int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age of a citizen");
                }
                age = value;
            }
        }
        protected long ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value.ToString().Length < 10 || value.ToString().Length > 10)
                {
                    throw new ArgumentException("Invalid id of a citizen");
                }
                id = value;
            }
        }

        public HumanCredentials(string name, int age, long id)
        {
            Name = name;
            Age = age;
            ID = id;
        }

        public virtual void CheckForFalsifiedID(int id)
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
    }
}
