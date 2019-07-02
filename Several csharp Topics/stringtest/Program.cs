using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string nam = "come closer";
            Console.WriteLine(nam.Clone());
            Console.WriteLine(nam.GetHashCode());
            //insert the string starting from the number length specified
            Console.WriteLine(nam.Insert(2, "Hello"));
            //delete all the characters from beginning to specified index
            Console.WriteLine(nam.Remove(6));
            // Console.WriteLine(nam.ToCharArray());
            char[] arr = nam.ToCharArray();
            Console.WriteLine(arr[3]);




            Console.ReadKey();


        }


        static void Work()
        {



        }

    }
}
