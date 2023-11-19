using System;
using System.Collections.Generic;
using System.Text;

namespace Combined_Restricions_On_Generic_Class
{
    interface ICheckCarsDetails
    {
        void CheckModel();
        void PrintCarDetails();
    }
    class Tesla<T> : Vehicle, ICheckCarsDetails where T : Vehicle
    {
        private List<string> listOfCars;

        public Tesla()
        {
            listOfCars = new List<string>();
        }
        public void CheckModel()
        {
            for (int i = 0; i < listOfCars.Count; i++)
            {
                if (listOfCars[i].Equals("Model S"))
                {
                    Console.WriteLine("{0} not bad.", listOfCars[i]);
                }
                else if (listOfCars[i].Equals("Model X."))
                {
                    Console.WriteLine("{0} - nice", listOfCars[i]);
                }
            }
        }
        public void AddModel(string model)
        {
            listOfCars.Add(model);
        }
        public void PrintCarDetails()
        {
            foreach (string car in listOfCars)
            {
                Console.WriteLine("Car: " + car);
            }
            Console.WriteLine("Seats: " + Seats);
        }
    }
}
