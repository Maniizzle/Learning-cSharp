using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStruct
{
    class Program
    {
        static string[] questions = { "\n1. WHO WAS THE FIRST MAN TO WALK ON THE MOON?",
                                     "\n2. When was Microsoft FOunded?,",
                                      "\n3. HOW many Local Government does Lagos have?",
                                  "\n4. _______ is the Minister of Science and Technology? ",
                                     "\n5. The Largest River in the World is?",
                                       "\n6. Who is the COO of Cyberspace Network Limited? ",
                                        "\n7. What does the eagle in the Nigerian coat of arm represent?",
             "\n8. Who is the current president of Liberia?",
            "\n9. 'OS' computer abbreviation usually means ?",
            "\n10. Who developed Yahoo?"};

        static void Main(string[] args)
        {
            // IList<int> myList = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            //Done();
            
int[] numbers = new int[10];
            int[] numbers1 = new int[4];
            var counter = 0;
            Random din = new Random();
            do
            {
                var randomNumber = din.Next(1, 11);
                if (Array.IndexOf(numbers, randomNumber) == -1)
                {
                    numbers[counter] = randomNumber;
                    counter++;
                }
            } while (counter < 10);
            counter = 0;
            {
                
               // for (int i = 0; i <= questions.GetUpperBound(0); i++)
              //  {
                    int den = din.Next(1, 11);
                    //   if(myList.Contains(den))

                    Console.WriteLine(den);
              //  }
                //Console.WriteLine(questions.GetUpperBound(0))
                Console.ReadLine();
            }
        }

        //public struct Circle
        //{

        //    public double R { set; get; }

        //    public Circle(double radius)
        //    {
        //        R = radius;
        //    }

        //    public Circle Circumference(Circle Mine)
        //    {
        //        return new Circle(2 * Math.PI * Mine.R);
        //    }
        //    public Circle Area(Circle Mine)
        //    {
        //        return new Circle(Math.PI * Math.Pow(Mine.R, 2));
        //    }

        //    public override string ToString()
        //    {
        //        return $"{R}";
        //    }


        //}

        //static void Done()
        //{
        //    Circle Ola = new Circle(4);
        //    Circle James = new Circle(5);
        //    Circle john = James.Circumference(James);
        //    Circle result2 = Ola.Area(Ola);
        //    Console.WriteLine(john);
        //    Console.WriteLine(result2);
        //    Console.ReadLine();
        //}


        public struct Circle
        {

            public double R { set; get; }

            public Circle(double radius)
            {
                R = radius;
            }

            public double Circumference()
            {
                return  (2 * Math.PI * R);
            }
            public double Area()
            {
                return (Math.PI * Math.Pow(R, 2));
            }

            public override string ToString()
            {
                return $"{R}";
            }


        }

        static void Done()
        {
            Circle Ola = new Circle(4);
            Circle James = new Circle(5);
            Double john = James.Circumference();
            Double result2 = Ola.Area();
            Console.WriteLine(john);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
