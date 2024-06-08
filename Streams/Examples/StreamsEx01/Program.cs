using System;
using System.IO;

namespace StreamsEx01
{
    /* 
     * This example opens a text file named "file.txt" 
     * and uses a StreamReader to read it line by line and output the contents to the console.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader streamReader = new("C:/Users/Computer/source/repos/Streams/Files/file.txt"))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
