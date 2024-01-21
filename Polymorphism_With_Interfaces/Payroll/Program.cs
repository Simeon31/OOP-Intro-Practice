using System;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee manager = new Manager("John Smith", 50000);
            IEmployee programmer = new Programmer("Jane Doe", 50, 40);

            Company company = new Company(new IEmployee[] { manager, programmer });

            company.PrintEmployeeInfo();
        }
    }
}
