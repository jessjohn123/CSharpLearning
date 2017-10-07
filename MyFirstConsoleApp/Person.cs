using System;
using System.Collections.Generic;
using System.Text;


namespace MyFirstConsoleApp
{
    public class Person  //IRun
    {
        public static int MinAge = 30;

        private readonly string _firstName;
        private readonly string _lastName;
        private decimal Salary { get; set; }
        private string EmailAddress;
        private IRun runner;

       
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public int Age { get; set; }

        public ref string GetEmailAddress()
        {
            return ref EmailAddress;
        }
        
        public Person()
        {
            //Empty Constructor;
        }

        ~Person()
        {
            Console.WriteLine("Finalizing Person");
        }

        public Person(string fName, string lName, int age)
        {
            _firstName = fName;
            _lastName = lName;
            Age = age;
        }

        public Person(string fName, string lName, int age, string email)
        {
            _firstName = fName;
            _lastName = lName;
            Age = age;
            EmailAddress = email;
        }

        public Person(string fName, string lName, int age, IRun _runner, decimal salary = 450000)
        {
            _firstName = fName;
            _lastName = lName;
            Age = age;
            //Default value
            Salary = salary;
            //This allows us to derive multiple behavior to diff person obj's
            runner = _runner; 
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello I'm a person!");
        }

        public override string ToString()
        {
            //return "My name is " + FirstName + " " + LastName + " " + "and I'm " + Age + " years old!" + "And I'm "; // And I'm a salaried/hourly
            return $"{FirstName} {LastName} {GetEmailAddress()}";
        }

        public void Run(int dist)
        {
            //Console.WriteLine("I'm running for {0} kms", dist);
            runner.Run(dist);
        }
    }
}
