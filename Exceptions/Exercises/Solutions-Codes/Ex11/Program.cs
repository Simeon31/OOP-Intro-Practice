using System;
using System.IO;

namespace Ex11_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    public class FileParseException : Exception
    {
        public string Filename { get; }
        public int LineNumber { get; }

        public FileParseException(string message, string filename, int lineNumber)
            : base(message)
        {
            Filename = filename;
            LineNumber = lineNumber;
        }
    }

    class Program
    {
        static void Main()
        {
            string filename = "numbers.txt"; // replace with your file

            try
            {
                ReadNumbers(filename);
            }
            catch (FileParseException e)
            {
                Console.WriteLine($"An error occurred in file {e.Filename} at line {e.LineNumber}: {e.Message}");
            }
        }

        static void ReadNumbers(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                int lineNumber = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!int.TryParse(line, out _))
                    {
                        throw new FileParseException("Non-integer value found", filename, lineNumber);
                    }

                    lineNumber++;
                }
            }
        }
    }
}
