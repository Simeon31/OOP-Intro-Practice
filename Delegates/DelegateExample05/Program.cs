using System;
using System.Collections.Generic;

namespace DelegateExample05
{
    class Program
    {
        delegate bool Filter(string s);
        delegate string Transform(string s);

        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Apple", "Banana", "Cherry", "Elderberry" };
            List<string> filteredStrings = new();
            List<string> transformedStrings = new();

            Filter filter = IsLong;
            Transform transform = ToUpper;

            foreach (string s in list)
            {
                if (filter(s))
                {
                    filteredStrings.Add(s);
                }
            }

            foreach (string s in filteredStrings)
            {
                transformedStrings.Add(transform(s));
            }

            foreach (string s in transformedStrings)
            {
                Console.WriteLine(s);
            }
        }

        static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        static bool IsLong(string s)
        {
            return s.Length >= 6;
        }
    }
}
