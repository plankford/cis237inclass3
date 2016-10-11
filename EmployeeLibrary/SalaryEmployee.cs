using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class SalaryEmployee : Employee
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

        //Override the ToString() method that is in the parent class Employee
        public override string ToString()
        {
            //Take the string the parents't ToString will return and add _weeklySalary to it
            //Must use the keyword base if tryig to acces the parents version of the method
            return base.ToString() + " " + this._weeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this._weeklySalary;
        }

        //Override the abstract method in the Employee Class. Because the EMployee class declares the 
        //method as abstract, this class MUST be implement it.
        public override decimal GetYearlySalary()
        {
            return this._weeklySalary * 52;
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
