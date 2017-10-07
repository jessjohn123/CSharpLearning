using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class FastRun : IRun
    {
        public void Run(int dist)
        {
            Console.WriteLine("I'm running fast for {0} kms", dist);
        }
    }
}
