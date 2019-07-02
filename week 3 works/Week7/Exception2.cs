using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Exception2
    {
        public static void kMain()
        {
            try
            {
                Console.WriteLine("Main method called.");
                // Method1();
                //Method2();
                throw new NotImplementedException();
                Console.WriteLine("Main method about to exit.");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        public static int Method1()
        {
            throw new ArgumentNullException();
               // NotImplementedException();
        }
        
    }
}
