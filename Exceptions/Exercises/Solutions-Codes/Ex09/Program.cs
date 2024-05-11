using System;
using System.IO;
using System.Text;

namespace Ex09_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    class Program
    {
        static void Main()
        {
            try
            {
                string content = ReadFileContent("example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("An error occurred: File does not exist.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        static string ReadFileContent(string filename)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }

            return sb.ToString();

            // return File.ReadAllText(filename); // Alternative
        }
    }
}
