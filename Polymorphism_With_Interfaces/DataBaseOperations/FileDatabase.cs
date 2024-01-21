using System;
using System.Collections.Generic;
using System.IO;

namespace DataBaseOperations
{
    class FileDatabase : IDatabase
    {
        private string filePath;

        public FileDatabase(string filePath)
        {
            this.filePath = filePath;
        }

        public void Insert(string record)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(record);
            }
        }

        public List<string> Read()
        {
            List<string> records = new();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    records.Add(line);
                }
            }
            return records;
        }
    }
}
