using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    public enum EmployeeType
    {
        Salaried,
        Hourly,
    }
    class Employee : Person
    {
        public EmployeeType Type { get; set; }
        public Employee(string fName, string lName, int age, EmployeeType type):base(fName,lName,age)
        {
            Type = type;
        }
    }
}
