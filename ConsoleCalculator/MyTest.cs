using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class MyTest
    {
        public string TestMethod()
        {
            string result = "no";
            result = Environment.GetEnvironmentVariable("ImportantNumber");
            return result;
        }
    }
}
