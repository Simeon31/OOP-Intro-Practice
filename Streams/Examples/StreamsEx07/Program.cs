using System;
using System.IO;

namespace StreamsEx08
{
    /* Exercise: Write the numbers 1 to 10 in a text file "numbers.txt", one number per line.
     * And read that file
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (BinaryWriter writer = new(File.Open("C://Users//Computer//source//repos//StreamsEx07//File//numbers.txt", FileMode.Create)))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        writer.Write(i);
                    }
                }

                using (BinaryReader reader = new(File.Open("C://Users//Computer//source//repos//StreamsEx07//File//numbers.txt", FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int number = reader.ReadInt32();
                        Console.WriteLine(number);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("The file was not found.");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
