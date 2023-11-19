using System;

namespace Combined_Restricions_On_Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla<Vehicle> car = new Tesla<Vehicle>();

            car.Seats = int.Parse(Console.ReadLine());
            car.AddModel("Model S");

            car.CheckModel();
            car.PrintCarDetails();
        }
    }
}
