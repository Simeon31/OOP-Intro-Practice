using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem03_WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> listOfWords = new List<string>();
                using (StreamReader wordsReader = new StreamReader("C://Users//Computer//source//repos//Problem03_WordsCount//Files//words.txt"))
                {
                    string word;
                    while ((word = wordsReader.ReadLine()) != null)
                    {
                        listOfWords.Add(word);
                    }
                }

                Dictionary<string, int> wordCounts = new Dictionary<string, int>();

                foreach (string word in listOfWords)
                {
                    wordCounts[word] = 0;
                }

                using (StreamReader textReader = new StreamReader("C://Users//Computer//source//repos//Problem03_WordsCount//Files//text.txt"))
                {
                    string line;
                    while ((line = textReader.ReadLine()) != null)
                    {
                        foreach (string word in listOfWords)
                        {
                            if (line.ToLower().Contains(word))
                            {
                                wordCounts[word]++;
                            }
                        }
                    }
                }

                var sortedWords = from entry in wordCounts orderby entry.Value descending select entry;
                using (StreamWriter writer = new StreamWriter("C://Users//Computer//source//repos//Problem03_WordsCount//Files//result.txt"))
                {
                    foreach (KeyValuePair<string, int> pair in sortedWords)
                    {
                        writer.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                }

                Console.WriteLine("Process completed.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File was not found");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory was not found");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
