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
            Console.WriteLine(sEmployee.NameAndSalary());
        }
    }
}
