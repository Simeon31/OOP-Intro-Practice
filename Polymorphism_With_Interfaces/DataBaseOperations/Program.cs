using System;
using System.Collections.Generic;

namespace DataBaseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase inMemoryDatabase = new InMemoryDataBase();
            IDatabase fileDatabase = new FileDatabase("database.txt");

            DataBaseManager inMemoryManager = new DataBaseManager(inMemoryDatabase);
            DataBaseManager fileManager = new DataBaseManager(fileDatabase);

            inMemoryManager.InsertRecord("Record 1");
            inMemoryManager.InsertRecord("Record 2");
            inMemoryManager.InsertRecord("Record 3");

            List<string> inMemoryRecords = inMemoryManager.ReadRecord();
            
            Console.WriteLine("In-memory database records: ");
            foreach (string record in inMemoryRecords)
            {
                Console.WriteLine(record);
            }

            fileManager.InsertRecord("Record A");
            fileManager.InsertRecord("Record B");
            fileManager.InsertRecord("Record C");

            List<string> fileRecords = fileManager.ReadRecord();

            Console.WriteLine(Environment.NewLine + "file database records: ");
            foreach (string record in fileRecords)
            {
                Console.WriteLine(record);
            }
        }
    }
}
