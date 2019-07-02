using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{

    
        public partial class Program
        {
            public static void Mainkk()
            {
                try
                {//Once an exception is thrown, others(including other exceptions) wont run 
                    Console.WriteLine("Main method called.");
                    Method1("Come home");
                    Method2();
                    Console.WriteLine("Main method about to exit.");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotImplementedException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Main method exited.");
            Console.ReadLine();
            }

            private static void Method1(string message = null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException(nameof(message), $"{nameof(Method1)} null was passed as argument ");
                }

                Console.WriteLine(message);
            }

            public static void Method2()
            {
                throw new NotImplementedException("This was intentional am bad like that.");
            }
        }
    
}
    

