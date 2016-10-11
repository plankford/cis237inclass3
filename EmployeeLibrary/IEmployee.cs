﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public interface IEmployee
    {
        //Declare all the public methods and properties that must be implemented
        //in child class

        int GetEmploymentDurationInYears();

        string GetAllEmployeeInformation();

        decimal GetYearlySalary();

    }
}
