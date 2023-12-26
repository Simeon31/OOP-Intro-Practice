using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    long id = long.Parse(input[2]);
                    string birthdate = input[3];

                    Citizen citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    Rebel rebel = new Rebel(name, age, group);
                    rebels.Add(rebel);
                }
            }

            string buyerName;
            while ((buyerName = Console.ReadLine()) != "End")
            {
                foreach (var citizen in citizens)
                {
                    if (citizen.Name == buyerName)
                    {
                        citizen.BuyFood();
                        break;
                    }
                }

                foreach (var rebel in rebels)
                {
                    if (rebel.Name == buyerName)
                    {
                        rebel.BuyFood();
                        break;
                    }
                }
            }

            int totalFood = citizens.Sum(c => c.Food) + rebels.Sum(r => r.Food);
            Console.WriteLine($"{totalFood}");
        }
    }
}
