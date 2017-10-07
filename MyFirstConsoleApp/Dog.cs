using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class Dog 
    {
        public string Name { get; set; }
        IRun runner;

        public Dog(string name, IRun runner)
        {
            this.Name = name;
            this.runner = runner;
        }

        public void Run(int distance)
        {
            runner.Run(distance);
        }
    }
}
