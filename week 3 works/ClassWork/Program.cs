using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {

    }


    public delegate void PerformOperations<in T>(params double[] number);
    class ClassWork
    {


        public static void Main()
        {

            PerformOperations<double> performOperations = Utility.Addednumbers;
            performOperations += Utility.SubtractNumbers;
            performOperations += Utility.MultiplyNumbers;
            performOperations += Utility.DivideNumbers;
            performOperations(11, 2, 3);
            Console.ReadLine();
        }
    }


    public class Utility
    {

        public static void Addednumbers(params double[] numbers)
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine($"{nameof(Addednumbers)} is {total}");
        }

        public static void SubtractNumbers(params double[] numbers)
        {
            int j = 1;
            double total = 0;
            total = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {    
                if (j <= numbers.Length - 1)
                 { total = total - numbers[j];
                    j++;
                }
            }
            Console.WriteLine($"{nameof(SubtractNumbers)} is {total}");
        }

        public static void MultiplyNumbers(params double[] numbers)
        {
            double total = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                total *= numbers[i];
            }
            Console.WriteLine($"{nameof(MultiplyNumbers)} is {total}");
        }

        public static void DivideNumbers(params double[] numbers)
        {
            double total = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                total /= numbers[i];
            }
            Console.WriteLine($"{nameof(DivideNumbers)} is {total}");
        }
    }




}
