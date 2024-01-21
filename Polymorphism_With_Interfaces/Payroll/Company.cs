using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Company
    {
        private IEmployee[] employees;

        public Company(IEmployee[] employees)
        {
            this.employees = employees;
        }

        public void PrintEmployeeInfo()
        {
            foreach (IEmployee employee in employees)
            {
                Console.WriteLine("Name: {0}", employee.GetName());
                Console.WriteLine("Salary: {0}", employee.GetSalary());
                Console.WriteLine();
            }
        }
    }
}
