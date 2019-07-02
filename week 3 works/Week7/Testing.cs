using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public class Testing2
    {

    }
    public class Testing
    {//testing the is and as operator
        public string Number { get; set; } = "sense";
        public static void Maink()
        {   //Testing the lambda operation with a linq query(checking for oa in the list)
            List<string> goat = new List<string>() { "goat", "animal", "oasis" };
            IEnumerable<string> few = goat.Where(v => v.Contains("oa"));
            foreach (var s in few)
            {
                Console.WriteLine(s);
            }
            ////Test(goat);
            Console.ReadLine();

            //if ((goat.Number as string) == "sense")

            //    Console.WriteLine("right code");

            //    Console.WriteLine(" wrong Code");
            //Console.ReadLine();

            //lambda expression with delegates \\expression lambda
            Func<string, string, string> Line = (x, y) => x + y;
            Console.WriteLine(Line("Big", "Fool"));
            Console.ReadLine();

        }


        public static void Test(object obj)
        {
            Testing t1;
            Testing2 t2;

            Console.WriteLine($"  obj is TEsting");
            t1 = (Testing)obj;


            if (obj is Testing2)
            {
                Console.WriteLine("obj is testing2");
                t2 = (Testing2)obj;
            }
            else
            {
                Console.WriteLine("obj is neither testing nor testing2");
            }
        }
        public delegate string Getit(List<string> goat);
        public static void Main()
        {
            Testing.Print(Console.ReadLine(), 4);

            Rectangle nite = new Rectangle(20,10,3,4);
            Console.WriteLine(nite.Position);


            List<string> avengers = new List<string>
        {
            "Iron Man",
            "Captian Marvel"
        };


            //Func<string, string, string>
            //Func<IList,string>=
            // Predicate<bool> find
            //Func <List<string>,string>= v=>avengers.Contains("Captain Marvel");
            var index = avengers.FindIndex(name => name == "Captain Marvel");
            Console.WriteLine(avengers[++index]);
            Console.WriteLine();

            var stack = new Stack<string>();
            stack.Push("Goat");
            stack.Push("Cow");
            stack.Push("Rat");
            stack.Push("Dog");

            Console.WriteLine(stack.Count);
            while (stack.Count >= 0)
            {
                Console.WriteLine(stack.Pop());
            }
            var gotLineup = new List<Student>()
        {
            new Student(){LastName ="Stark", FirstName ="Robb"},
             new Student(){LastName ="Lannister", FirstName ="Sersei"},
            new Student(){LastName ="Stark", FirstName ="Sansa"},
            new Student(){LastName ="Lannister", FirstName ="Jamie"},
             new Student(){LastName ="Stark", FirstName ="Arya"},
            new Student(){LastName ="Lannister", FirstName ="Tyrion"},
        };
            gotLineup.Sort();
            Console.ReadLine();


        }

        public static void Print(string str, int tr)
        {
            Console.WriteLine($"{str}  {tr}");
        }
    }

    internal class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public class Shape
    {
        public Shape(int width, int height, int x, int y)
        {
            Size = new Size
            { Width = width, Height = height };
            Position = new Position { X = x, Y = y };
        }
        
        public Position Position { get; }
        public Size Size { get; } 
    }

    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString() => $"Width: {Width}, Height: {Height}";
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"X: {X}, Y: {Y}";
    }
    public class Rectangle:Shape
    {
        public Rectangle(int width,int height,int x,int y):base(width,height,x,y)
        {

        }
    }

}