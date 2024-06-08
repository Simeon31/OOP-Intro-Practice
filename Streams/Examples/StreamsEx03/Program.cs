using System;
using System.IO;

namespace StreamsEx03
{
    /*
     * This example demonstrates writing two binary values ​​- an integer and a floating point number to a file "data.bin" using BinaryWriter, 
     * then reading the values ​​from the same file using BinaryReader and outputting them to the console.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (BinaryWriter binaryWriter = new(File.Open("data.bin", FileMode.Create)))
                {
                    int number = 40;
                    double pi = 3.14159;

                    binaryWriter.Write(number);
                    binaryWriter.Write(pi);
                }

                using (BinaryReader binaryReader = new(File.Open("data.bin", FileMode.Open)))
                {
                    int number = binaryReader.ReadInt32();
                    double pi = binaryReader.ReadDouble();

                    Console.WriteLine($"Number: {number}");
                    Console.WriteLine($"PI: {pi}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
