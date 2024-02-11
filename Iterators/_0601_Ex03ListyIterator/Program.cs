using System;
using System.Collections.Generic;
using System.Linq;

namespace _0601_Ex03ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;
            string cmd = String.Empty;

            try
            {
                do
                {
                    List<string> list = cmd.Split().ToList();
                    string operation = list[0];

                    switch (operation)
                    {
                        case "Create":
                            listyIterator = new ListyIterator<string>(list.Skip(1));
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "PrintAll":
                            foreach (var item in listyIterator)
                            {
                                Console.Write($"{item} ");
                            }
                            break;
                    }
                } while (!"END".Equals(cmd = Console.ReadLine()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
