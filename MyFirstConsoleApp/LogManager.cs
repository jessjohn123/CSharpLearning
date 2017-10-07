using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyFirstConsoleApp
{
    public class LogManager
    {
        public string FileName { get; set; }
        public LogManager(string fName)
        {
            FileName = fName;
        }

        public void Generate()
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Line {i + 1}");
                }
            }
        }
    }
}
