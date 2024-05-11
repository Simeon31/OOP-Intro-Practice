using System;
using System.IO;
using System.Security;

namespace Ex12_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the full path to a file: ");
                string path = Console.ReadLine();

                string content = File.ReadAllText(path);
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The path is a zero-length string, contains only white space, or contains one or more invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path exceeds the system-defined maximum length.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only, or this operation is not supported on the current platform, or path specified a directory, or the caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
        }
    }
}
