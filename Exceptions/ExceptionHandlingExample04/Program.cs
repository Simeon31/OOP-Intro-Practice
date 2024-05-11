using System;
using System.IO;

namespace ExceptionHandlingExample04
{
    class Program
    {
        static void Main(string[] args)
        {
            string souceFile = "source.txt";
            string destinationFile = "destination.txt";

            try
            {
                StreamReader sourceReader = new StreamReader(souceFile);

                StreamWriter destinationWriter = new StreamWriter(destinationFile);

                // Copying file
                string line;
                while ((line = sourceReader.ReadLine()) != null)
                {
                    destinationWriter.WriteLine(line);
                }

                // Closing files
                sourceReader.Close();
                destinationWriter.Close();

                Console.WriteLine("File copied successfully.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
