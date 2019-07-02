using Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime interviewDate = new DateTime(2019,4,19,10,0,0);
            var interviewDuration = interviewDate.AddHours(+4);
            Console.WriteLine($"interview ends at {interviewDuration: t}");

            DateTime christmasDay = new DateTime(2019, 12, 25);
            DateTime today = DateTime.Today;
            int month= (int) christmasDay.Subtract(today).TotalDays/30;
            int days = (int)christmasDay.Subtract(today).TotalDays % 30;
            
            
            Console.WriteLine($"Christmas is {month} month and {days} days from Today");
            Console.ReadKey();

        }
    }
}
