using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    class InMemoryDataBase : IDatabase
    {
        private List<string> records;

        public InMemoryDataBase()
        {
            records = new List<string>();
        }

        public void Insert(string record)
        {
            records.Add(record);
        }

        public List<string> Read()
        {
            return records;
        }
    }
}
