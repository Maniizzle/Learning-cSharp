using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Another2
    { public static void Maink()
        {
            //Array names = Enum.GetValues(typeof(Gender));

            //foreach (int name in names)
            //{
            //    Console.WriteLine(name);
            //}

            var myclass = new Class1() { Number = 20 };
            var myclass2 = new Class1() { Number = 15 };
            var myclass3 = new Class1() { Number = 10 };

            Console.WriteLine($"Adding {nameof(myclass)} and {nameof(myclass2)} gives {(myclass + myclass2)}");
            Console.WriteLine($"Subtracting {nameof(myclass)} from {nameof(myclass2)} gives {(myclass - myclass2)}");
            Console.WriteLine($"Multiplying {nameof(myclass)} and {nameof(myclass2)} gives {(myclass * myclass2)}");
            myclass3 += myclass2;
            Console.WriteLine($"Myclass is now {myclass.Number}");
            myclass -= myclass2;
            Console.WriteLine($"Myclass3 is now {myclass.Number}");
            myclass++;
            Console.WriteLine($"After Increment you get {myclass}");
            //Console.WriteLine($"{myclass++} after increment NUmber becomes {myclass.Number}");
            //Console.WriteLine($"{myclass--} after increment NUmber becomes {myclass.Number}");
            Console.ReadLine();
        }
    }

    public enum Gender
    {
        UNKNOWN,
        MALE,
        FEMALE
    }
    public struct Class1
       {
        public int Number { get; set; }

        public static Class1 operator +(Class1 class1,Class1 class2)
        {
            var class3 = new Class1() { Number = class1.Number + class2.Number };
            return class3;
        }

        public static Class1 operator -(Class1 class1, Class1 class2)
        {
            var class3 = new Class1() { Number = class1.Number - class2.Number };
            return class3;
        }
        public static Class1 operator ++(Class1 class1)
        {
            
            var class3 = new Class1() { Number = class1.Number + 1 };
            return class3 ;
        }
        public static Class1 operator --(Class1 class1)
        {
            var class3 = new Class1() { Number = class1.Number-- };
            return class3;
        }
        
        public static Class1 operator *(Class1 class1,Class1 class2)
        {
            var class3 = new Class1() { Number = class1.Number* class2.Number };
            return class3;
        }
        
        public override string ToString()
        {
            return this.Number.ToString();
        }
    }

    //public class Class2
    //{
    //    public int Number { get; set; }
    //}
}
