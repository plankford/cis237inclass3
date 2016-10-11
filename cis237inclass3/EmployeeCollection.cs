using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class EmployeeCollection : IEmployeeCollection
    {
        //I can do this because I am instanciating an employee array and not a single employee
        //I can instantiate this array and a Employee type because it is an array.
        //Even though I can't instantiate a single Emoplyee since it is abstract, and array
        //is fine. I just have to make sure that I put non-abstract instances into it
        IEmployee[] employees = new Employee[10];

        int currentIndex;

        //Constructor
        public EmployeeCollection()
        {
            currentIndex = 0;
        }

        public void add(string FirstName, string LastName, DateTime StartDate, decimal Salary)
        {
            employees[currentIndex++] = new SalaryEmployee(FirstName, LastName, StartDate, Salary);
        }

        public void add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek)
        {
            employees[currentIndex++] = new HourlyEmployee(FirstName, LastName, StartDate, HourlyRate, HoursPerWeek);
        }

        public string GetPrintString()
        {
            //declare a blank string to start
            string allOutput = "";

            //for each employee in the collection
            foreach (Employee employee in employees)
            {
                //So long as the employee is not null
                if (employee != null)
                {
                    //concat the employee information
                    allOutput += employee.ToString() + Environment.NewLine;

                    //Right Into The Danger Zone!!!!
                    //We need to check to see if the type is of SalaryEmployee otherwise, calling
                    //the NameAndSalary Method would fail for all other types of classed
                    if (employee.GetType() == typeof(SalaryEmployee))
                    {
                        //This is called a down cast because we are down casting it from the type
                        //of Employee down to the type of SalaryEmployee
                        allOutput += ((SalaryEmployee)employee).NameAndSalary() + Environment.NewLine;
                    }                   
                }
            }
            //Return the concat string
            return allOutput;
        }
    }
}
