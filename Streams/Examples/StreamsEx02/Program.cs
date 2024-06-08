using System;
using System.IO;

namespace StreamsEx02
{
    /*
     * This example creates a file named "file.txt" and uses a StreamWriter to write text data to the file. 
     * After successful recording, a message is displayed on the console.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter streamWriter = new("C:/Users/Computer/Documents/file.txt"))
                {
                    streamWriter.WriteLine("Hello C#!");
                    streamWriter.WriteLine("This is a sample text");
                }

                Console.WriteLine("The text was successfully writen in the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
