using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string command = String.Empty;

            while (!(command = Console.ReadLine()).Equals("Party!"))
            {
                string[] commands = command.Split();
                string action = commands[0];
                string condition = commands[1];
                string parameter = commands[2];

                Predicate<string> predicate = GetPredicate(condition, parameter);

                if (action == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (action == "Double")
                {
                    for (int i = names.Count - 1; i >= 0; i--)
                    {
                        if (predicate(names[i]))
                        {
                            names.Insert(i, names[i]);
                        }
                    }
                }
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string condition, string parameter)
        {
            switch (condition)
            {
                case "StartsWith":
                    return name => name.StartsWith(parameter);
                case "EndsWith":
                    return name => name.EndsWith(parameter);
                case "Length":
                    return name => name.Length == int.Parse(parameter);
                default:
                    return null;
            }
        }
    }
}
