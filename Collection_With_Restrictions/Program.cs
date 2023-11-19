using System;

namespace Collection_With_Restrictions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shop> list = new List<Shop>();

            Console.WriteLine("Enter location: ");
            list.Location = Console.ReadLine();

            Console.WriteLine("Enter name of shop: ");
            list.Name = Console.ReadLine();

            list.GetAddress("Steet 45A");
            list.Print();

            list.Add("New address");
            list.Add("One more addreess");

            list.Remove("One more addreess");

            list.PrintNewDetails();
        }
    }
}
