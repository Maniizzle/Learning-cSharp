using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          





            DateTime today = DateTime.Today;

            DateTime now = DateTime.Now;
            DateTime nowUtc = DateTime.UtcNow;
            WriteLine($"Now :{now}, UTC Now : {nowUtc}");

            DateTime dateOfBirth = new DateTime(1993, 06, 05);
            double age = DateTime.Today.Subtract(dateOfBirth).TotalDays;
            WriteLine(age / 365);


            int durationInDays = 7;
            DateTime subscriptionDate = DateTime.Now, expiresOn = subscriptionDate.AddDays(durationInDays);
           

            ReadKey();

        }

        static string Testing()
        {
            
            return "";
        }
    }
}
