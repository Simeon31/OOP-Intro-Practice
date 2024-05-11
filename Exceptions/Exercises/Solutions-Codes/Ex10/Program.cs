using System;
using System.IO;

namespace Ex10_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    class Program
    {
        static void Main()
        {
            string inputFile = "input.zip"; 
            string outputFile = "output.zip"; 

            byte[] content = ReadFileContent(inputFile);
            WriteFileContent(outputFile, content);

            Console.WriteLine("Are files identical? " + CompareFiles(inputFile, outputFile));
        }

        static byte[] ReadFileContent(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[64 * 1024]; // 64 KB
                using (MemoryStream ms = new MemoryStream())
                {
                    int bytesRead;
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, bytesRead);
                    }
                    return ms.ToArray();
                }
            }
        }

        static void WriteFileContent(string filename, byte[] content)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                fs.Write(content, 0, content.Length);
            }
        }

        static bool CompareFiles(string file1, string file2)
        {
            byte[] content1 = File.ReadAllBytes(file1);
            byte[] content2 = File.ReadAllBytes(file2);

            if (content1.Length != content2.Length)
            {
                return false;
            }

            for (int i = 0; i < content1.Length; i++)
            {
                if (content1[i] != content2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
