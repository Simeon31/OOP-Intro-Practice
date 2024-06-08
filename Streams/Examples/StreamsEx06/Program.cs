using System;
using System.IO;
using System.Text;

namespace StreamsEx06
{
    /*
     * This example creates a MemoryStream that is initialized with the specified byte array. 
     * The program then reads the data from the MemoryStream and outputs it to the console.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes("Hello, MemoryStream!");

                using (MemoryStream memoryStream = new(data))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = memoryStream.Read(buffer, 0, buffer.Length);
                    string text = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
