using System;
using System.IO;

namespace StreamsEx08
{
    /* Create a program that copies the contents of one file to another file.
    */
    class Program
    {
        private const string SOURCEFILENAME = "C://Users//Computer//source//repos//StreamsEx09//Files//text.txt";
        private const string DESFILENAME = "C://Users//Computer//source//repos//StreamsEx09//Files//file.txt";

        static void Main(string[] args)
        {
            try
            {
                File.Copy(SOURCEFILENAME, DESFILENAME, true);
                Console.WriteLine("File successfully copied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
        }
    }
}
