using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Programmer : IEmployee
    {
        private string name;
        private decimal hourlyRate;
        private int hoursWorked;

        public Programmer(string name, decimal hourlyRate, int hoursWorked)
        {
            this.name = name;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }
}
