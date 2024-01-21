using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    class DataBaseManager
    {
        IDatabase database;

        public DataBaseManager(IDatabase database)
        {
            this.database = database;
        }

        public void InsertRecord(string record)
        {
            database.Insert(record);
        }

        public List<string> ReadRecord()
        {
            return database.Read();
        }
    }
}
