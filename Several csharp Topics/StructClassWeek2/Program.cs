using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructClassWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeValue(4);
        }

        public struct Point
        {//properties
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public Point Add(Point pt)
            {
                return new Point(X + pt.X, Y + pt.Y);
            }
            
            public Point Multiply(Point jt)
            {
                return new Point(X * jt.X, Y*jt.Y);
            }

            
             public double Distance(Point rt)
            {
                double dist = (Math.Pow((rt.X - X), 2) + Math.Pow((rt.Y - Y), 2));
                return Math.Sqrt(dist);
            }
            //public Point Division(Point gt)
            //{
            //    return new Point(X/gt.X)
            //}
            public override string ToString()
            {
                return $"[X:{X}, Y:{Y}]";
            }

            
        }
        static void ChangeValue(int value)
        {
            Point myPt = new Point(10, 10);
            Point newPt = new Point(10, 20);
            var result = newPt.Distance(myPt);
            Console.WriteLine(result);

            Point set = new Point(30, 40), set2 = new Point(90, 20),set3=new Point(80,100);
            
            Console.ReadLine();
        }
    }
}
