using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.LCD.Result = "30002";
            Console.WriteLine(cal.LCD.Result);        }
    }
}
