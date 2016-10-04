using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee sEmployee = new SalaryEmployee("Patrick", "Lankford", new DateTime(2011, 10, 14), 1428.65m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            //Output the SalaryEmployee converted to a string
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee2.ToString());

            HourlyEmployee hEmployee = new HourlyEmployee("Jane", "Doe", new DateTime(2012, 12, 01), 11.52m, 32m);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());
            Console.WriteLine(hEmployee.GetAllEmployeeInformation());
        }
    }
}
