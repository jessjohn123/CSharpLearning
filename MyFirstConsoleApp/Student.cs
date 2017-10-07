using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    public enum StudentLevel
    {
        HighSchool,
        UnderGraduate,
        Graduate
    }

    public class Student : Person
    {
        
        public string University { get; set; }
        public double AvgGrade { get; set; }
        public StudentLevel Level { get; set; }

        public Student(string fName, string lName, int age, IRun run) : base(fName, lName, age, run)
        {

        }

        public Student(string fName, string lName, int age, string uni, double grade) : base(fName, lName, age)
        {
            University = uni;
            AvgGrade = grade;
        }

        public Student(string fName, string lName, int age, StudentLevel level) : base(fName, lName, age)
        {
            Level = level;
        }

        public override void SayHello()
        {
            //base.SayHello();
            Console.WriteLine("Hello I'm a student!");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
