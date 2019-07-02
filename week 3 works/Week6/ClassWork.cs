using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{

    public delegate void PerformOperations(params int[] number);
    class ClassWork
    {

        
        public static void Main()
        {
            Utility utility = new Utility();
            int[] number = { 2, 4, 3, 3, 6, 7, 8, 8, 9 };
            PerformOperations performOperations = utility.Addednumbers;
            performOperations(number);
            Console.ReadLine();
        }
    }

    
    public class Utility
        {
            public int[] numbers;
            public  void Addednumbers(params int[] numbers)
            {
                int total = 0;
                for(int i=0; i < numbers.Length; i++)
                {
                    total += numbers[i];
                }
                Console.WriteLine($"{nameof(Addednumbers)} is {total}");
            }

            public static void SubtractNumbers()
            {

            }
        }

    
}
