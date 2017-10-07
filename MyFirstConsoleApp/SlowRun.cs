using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class SlowRun : IRun
    {
        public void Run(int dist)
        {
            Console.WriteLine("I'm running slowly for {0} kms", dist);
        }
    }
}
