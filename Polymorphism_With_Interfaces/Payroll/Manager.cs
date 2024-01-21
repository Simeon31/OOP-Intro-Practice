using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Manager : IEmployee
    {
        private string name;
        private decimal salary;

        public Manager(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetSalary()
        {
            return salary;
        }
    }
}
