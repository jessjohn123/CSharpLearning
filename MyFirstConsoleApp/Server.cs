using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class Server
    {
        public string Name { get; set; }
        public int RAM { get; set; }
        public bool Status { get; set; }
        public string Location { get; set; }

        public override string ToString() => $"{Name} / {RAM} / {Location}";
        
    }
}
