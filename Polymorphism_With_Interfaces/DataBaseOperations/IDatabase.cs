using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    interface IDatabase
    {
        void Insert(string record);
        List<string> Read();
    }
}
