using System;
using System.Net;

namespace Ex13_Exeptions_Throwing_And_Handling_Exeptions_Exercises
{
    class Program
    {
        static void Main()
        {
            string url = "http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.png"; // replace with your URL
            string filename = "downloaded_file.png"; 

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filename);
                }

                Console.WriteLine("File downloaded successfully.");
            }
            catch (WebException e)
            {
                Console.WriteLine($"WebException: {e.Message}");
                if (e.Status == WebExceptionStatus.ConnectFailure)
                {
                    Console.WriteLine("Are you connected to the Internet?");
                }
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine($"NotSupportedException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
