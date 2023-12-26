using System;

namespace Border_Control
{
    class RobotCredentials
    {
        private string model;
        private long id;
        protected string Model
        {
            get
            {
                return $"{model}";
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Robot without a model");
                }
                model = value;
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
                if (value.ToString().Length < 1)
                {
                    throw new ArgumentException("Invalid id of a robot");
                }
                id = value;
            }
        }
        public RobotCredentials(string model, long id)
        {
            Model = model;
            ID = id;
        }

        public virtual void CheckForFalsifiedID(int id)
        {
            long lastThreeDigits = ID % 1000;
            int falsifiedDigit = (int)lastThreeDigits;

            Console.WriteLine();
            if (lastThreeDigits == id)
            {
                Console.WriteLine("{0} with ID: {1} does not pass", Model, ID);
                Console.WriteLine("Falsified number: {0}", falsifiedDigit);
            }
            else
            {
                Console.WriteLine("Model: {0} Pass", Model);
            }
        }
    }
}
