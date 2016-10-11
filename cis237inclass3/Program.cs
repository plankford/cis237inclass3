using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeLibrary.SalaryEmployee sEmployee = new SalaryEmployee("Patrick", "Lankford", new DateTime(2011, 10, 14), 1428.65m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            //Output the SalaryEmployee converted to a string
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee2.ToString());

            HourlyEmployee hEmployee = new HourlyEmployee("Jane", "Doe", new DateTime(2012, 12, 01), 11.52m, 32m);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());
            Console.WriteLine(hEmployee.GetAllEmployeeInformation());

            //Declare new collection
            IEmployeeCollection employeeCollection;
            //Instantiate the collection with the concrete class even though it is going into an interface
            employeeCollection = new EmployeeCollection();
            //Call the method below to add the employee to the collection
            AddNewEmployees(employeeCollection);

            //Send collection to the print method
            PrintEmployees(employeeCollection);         
        }

        static void AddNewEmployees(IEmployeeCollection employeeCollection)
        {
            //Add a couple of Salary Employees
            employeeCollection.add("James", "Kirk", new DateTime(2016, 3, 2), 523m);
            employeeCollection.add("Jane", "Doe", new DateTime(2016, 2, 1), 875m);
            //Add a couple of Hourly Employees
            employeeCollection.add("John", "Doe", new DateTime(2016, 5, 4), 48m, 40);
            employeeCollection.add("Jimmy", "Neutron", new DateTime(2016, 6, 21), 53m, 38);
        }

        static void PrintEmployees(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine(employeeCollection.GetPrintString());
        }
    }
}
