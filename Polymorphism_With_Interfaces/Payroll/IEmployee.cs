using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    interface IEmployee
    {
        string GetName();
        decimal GetSalary();
    }
}
