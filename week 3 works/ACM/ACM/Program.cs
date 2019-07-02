using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    // The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.
    //enum Day : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
    //The approved types for an enum are byte, sbyte, short, ushort, int, uint, long, or ulong.
    //<modifier> enum { }
    public enum Day { Sun=1, Mon, Tue, Wed, Thu, Fri, Sat };
     enum Color { Red, Green, Blue }
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("private method");
        }

        internal void Test4()
        {
            Console.WriteLine("internal method");
        }
        protected void Test3()
        {
            Console.WriteLine("protected method");
        }
        protected internal void Test2()
        {
            Console.WriteLine("protected internal method");
        }
        public void Test5()
        {
            Console.WriteLine("public method");
        }
        static void Main4(string[] args)
        {
            Program p = new Program();
            p.Test1();p.Test2();p.Test4();p.Test5();p.Test3();
            //switch (expression)
            //{
            //    // declarations
            //    // . . .
            //    case constant_expression:
            //        // statements executed if the expression equals the
            //        // value of this constant_expression
            //        break;
            //    default:
            //        // statements executed if expression does not equal
            //        // any case constant_expression
            //}
            Day game = Day.Sat;
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);


            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 20;
                    goto case "1";
                case "3":
                case "large":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)

                Console.WriteLine("Please insert {0} cents.", cost);

            Color c = (Color)(new Random()).Next(0, 3);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
               
            }
            //case 'a' :
            //case 'b' :
            //case 'c' :
            //case 'd' :
            //case 'e' :
            //case 'f' :  hexcvt(c);


            //ACMCustomer john = new ACMCustomer("JOHN","20, Fadunsi street",Cities.Jos,"Nigeria");
            //Console.WriteLine($"City is {john.City}");
            //john.City = Cities.AkwaIbom;
            //Console.WriteLine($"Modified City is {john.City}");
            //Console.WriteLine($"Country Name is {john.Country}");

            //Console.WriteLine($"Address is {john.Address}");

            //john.City = Cities.Kano;
            //john.Address = "34, Kanuri Crescent";
            //Console.WriteLine($"Address is {john.Address}");

            Console.ReadKey();
        }
    }
}
