using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Services
{
    public class FooServices
    {
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "Bob",
                "Mary",
                "John",
                "Jane"
            };
        }

    }
}
