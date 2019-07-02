using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWeek3
{
    class shere
    {
        private   int x;
        public shere(int i)
        {
            x = i;

            Console.WriteLine(x);

        }
        //copy constructor
        public shere(shere dew)
        {
            x = dew.X;
        }
        public int X { get => x; set => x = value; }

        public void Display()
        {
            Console.WriteLine("x is " + x);
        }

        public static void Main()
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            Console.WriteLine(grades.Count);
            shere dog = new shere(4);
            shere sew = new shere(dog);
            dog.Display();
            //dog.x = 20;
            Console.WriteLine("Field dog is " + dog.x);
            dog.X = 25;
            Console.WriteLine("Properties dog is " + dog.X);
            Console.WriteLine("sew Field dog is " + sew.X);
            dog.Display();
            Console.ReadLine();

        }

    }
}