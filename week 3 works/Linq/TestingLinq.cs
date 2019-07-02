using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ContactWriters
{
    class TestingLinq
    {
        class Program
        {

            static void Main(string[] args)
            {
                //List<string> companies = new List<string>() { "Consolidated Messenger LTD",
                //   "Coho Winery", "Wide World Importers", "Graphic Design Institute", "Adventure Works LTD",
                //   "Humongous Insurance", "Woodgrove Bank LTD", "Margie's Travel", "Northwind Traders",
                //   "Blue Yonder Airlines", "Trey Research LTD", "Fourth Coffee LTD" };



                //var query = from c in companies
                //            where c.EndsWith("LTD")
                //            orderby c descending
                //            select c;
                //// new Company()
                //{
                //    Name = c.ToUpper(),
                //    Employees = new string[1] { "" }
                //}).ToList();



                //Array.ForEach(query.ToArray(), c => WriteLine(c.Name));

                //WriteLine("=======================");
                //companies.AddRange(new string[]
                //{
                //"The Phone Company",
                //"Wingtip Toys LTD",
                //"Lucerne Publishing",
                //"Alpine Ski House",
                //"Southridge Video LTD",
                //"City Power & Light",
                //});

              //  Array.ForEach(query.ToArray(), c => WriteLine(c.Name));

                List<Company> josh = new List<Company>(){
                    new Company { Name = "Cyberspace", Employees =new string[] { "Obafemi", "Chidinma"} },
                 new Company { Name = "Airtel", Employees =new string[] { "Pelumi", "Chidinma" } },
                 new Company { Name = "Swift", Employees =new string[] { "Olamide", "Kayinsola" } },
                 new Company { Name = "Spectranet", Employees =new string[] { "Chidinma", "David" } },
                 new Company { Name = "Specs", Employees =new string[] {  } } };
                // new Company(){ Name: "Josh", Employees: {new string[] { "Umu", "Nas", "Pele" }, }


                //                var j = josh.Where(c => c.Employees.Where(p => p == "Chidinma").Any());
                //                foreach (var item in j)
                //                {
                //                    Console.WriteLine(item.Employees.Count());
                //                }

                //                ReadLine();
                ////                var k = query.Where(c => c.Employees.Equals("ade"));


                //(from c in companies
                // where c.EndsWith("LTD")
                // orderby c descending
                // select new Company()
                // {
                //     Name = c.ToUpper(),
                //     Employees = new string[3] { "Umu", "Nas", "Pele" }
                // }).ToList();

                //List<Company> josh = new List<Company>(){
                //    new Company { Name = "Cyberspace", Employees =new string[] { "Obafemi", "Chidinma"} },
                // new Company { Name = "Airtel", Employees =new string[] { "Pelumi", "Chidinma" } },
                // new Company { Name = "Swift", Employees =new string[] { "Olamide", "Kayinsola" } },
                // new Company { Name = "Spectranet", Employees =new string[] { "Chidinma", "David" } },
                // new Company { Name = "Specs", Employees =new string[] {  } } };
                //// new Company(){ Name: "Josh", Employees: {new string[] { "Umu", "Nas", "Pele" }, }
                //var john =
                //           from c in query

                //           select (from b in c.Employees
                //                   where b.Equals("")
                //                   //Contains("Nas")
                //                   select c);


                var john1 = from c in josh
                            where (from b in c.Employees
                                   where (b == "chidinma") && c.Employees.Any()
                                   select b)
                            select c;
                            //Contains("Nas")
                           // select c;

                //var john = from c in josh
                //               // select
                //           where (c.Employees.Any(b => b == "Chidinma"))
                //           select c;
                var john = from c in josh
                               // select
                           where (from b in c.Employees
                                  where b == "Chidinma"
                                  select b).Any() 
                           select c;
                //Contains("Nas")



                foreach (var item in john)
                {
                    foreach (var items in item)
                    {
                        Console.WriteLine(items.Name);
                    }
                    
                }
                Console.ReadLine();
            }
        }

        public class Company
        {
            public string Name { get; set; }

            public string[] Employees { get; set; }
        }

        public class Person
        {
            private Person()
            {

            }
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public static Person CreatePerson(string lastName, string firstName)
            {
                if (string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(lastName))
                    throw new ArgumentNullException();

                return new Person()
                {
                    LastName = lastName,
                    FirstName = firstName
                };
            }
        }
    }
}
