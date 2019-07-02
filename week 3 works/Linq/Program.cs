using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWriters
{
    class Program 
    {
        static void Mainkl(string[] args)
        {
            //ByteConversions.ByteConversion(15740924);
            //ByteConversions.DisplayFilesinDirectory("C:\\Windows");
            //Console.ReadLine();
            var gotLineup = new List<Cast>()
        {
            new Cast(){LastName ="Stark", FirstName ="Arya",Age=37},
             new Cast(){LastName ="Lannister", FirstName ="Sersei",Age=28},
            new Cast(){LastName ="Stark", FirstName ="Sansa",Age=25},
            new Cast(){LastName ="Lannister", FirstName ="Jamie",Age=25},
             new Cast(){LastName ="Stark", FirstName ="Arya",Age=35},
            new Cast(){LastName ="Lannister", FirstName ="Tyrion",Age=40},
        };


            gotLineup.Sort(new CastComparer(CastCompareType.LastName));
            foreach (var p in gotLineup)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();

            //Contact sarah = new Contact()
            //{ FirstName = "sarah", AgeInYears = 42 };

            //var sarahwriter = new ContactConsoleWriter(sarah);
            //sarahwriter.Write();
            //sarahwriter.Wrong();
            //Console.WriteLine("hello world!");

            //Console.ReadLine();
            //}
            ////gotLineup.FindIndex(Search);

            //public static bool Search(Cast hero)
            //{
            //    if (hero.FirstName.Equals( StringComparison.OrdinalIgnoreCase))
            //        return true;
            //    return false;

        }
    }
}
