using System;

namespace ExceptionHandlingExample05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance: ");
            string distanceInput = Console.ReadLine();
            double distance = 0.0;

            try
            {
                distance = double.Parse(distanceInput);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return;
            }

            Console.Write("Enter the source unit (km/mi): ");
            string sourceUnit = Console.ReadLine();
            double factor = 0.0;
            string sourceName = String.Empty;

            switch (sourceUnit)
            {
                case "km":
                    factor = 0.621371;
                    sourceName = "kilometers";
                    break;
                case "mi":
                    factor = 1.60934;
                    sourceName = "miles";
                    break;
                default:
                    Console.WriteLine("Error: Invalid input.");
                    break;
            }

            Console.Write("Enter the target unit (km/mi): ");
            string tagetUnit = Console.ReadLine();
            double targetFactor = 0.0;
            string targetName = String.Empty;

            switch (tagetUnit)
            {
                case "km":
                    targetFactor = 1;
                    targetName = "kilometers";
                    break;
                case "mi":
                    targetFactor = 1.60934;
                    targetName = "miles";
                    break;
                default:
                    Console.WriteLine("Error: Invalid input.");
                    break;
            }

            double result = (distance * factor) / targetFactor;
            Console.WriteLine($"{distance} {sourceName} is equal to {result} {targetName}.");
        }
    }
}
