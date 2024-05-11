using System;
using System.IO;

namespace ExceptionHandlingExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader("input.txt");
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                streamReader.Close();

            }

            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Error: File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
