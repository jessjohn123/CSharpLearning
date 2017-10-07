using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    public enum SportType
    {
        Team,
        Individual
    }
    class Athlete:Person
    {
        public SportType SType { get; set; }
        public Athlete(string fName, string lName, int age, SportType sType):base(fName, lName, age)
        {
            SType = sType;
        }   
    }
}
