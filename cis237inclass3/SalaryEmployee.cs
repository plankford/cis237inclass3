using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //Variable
        private decimal _weeklySalary;

        //Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //Methods
        public string NameAndSalary()
        {
            //call the Parent(Employee) ToString method
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }

        //Constructor
        public SalaryEmployee(string FirstName, string LastName, DateTime StartDate, decimal WeeklySalary) 
            //This calls the parent classes constructor to that we do not have to repeat work that the parent is doing
            : base(FirstName, LastName, StartDate)
        {
            _weeklySalary = WeeklySalary;
        }

        public SalaryEmployee() : base()
        {

        }
    }
}
