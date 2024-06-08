using System;
using System.IO;

namespace Problem01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new(File.Open("C://Users//Computer//source//repos//Streams-Exercicess//File//file.txt", FileMode.Open)))
                {
                    int lineNumber = -1;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNumber % 2 == 0)
                        {
                            Console.WriteLine(line);
                        }

                        lineNumber++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File was not found");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory was not found");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
