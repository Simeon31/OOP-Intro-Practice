using System;
using System.IO;

namespace Problem02_NumberOfLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new("C://Users//Computer//source//repos//Problem02_LineNumbers//Files//text.txt"))
                {
                    int lineNumber = 0;
                    string line;

                    using (StreamWriter writer = new("C://Users//Computer//source//repos//Problem02_LineNumbers//Files//output.txt", false))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;
                            writer.WriteLine($"Line {lineNumber}: {line}");
                        }
                    }
                }

                Console.WriteLine("Process completed.");
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
