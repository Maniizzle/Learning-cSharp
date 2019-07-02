using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM;

namespace ClassWeek3
{
    class Demo2
    {
        
        public static void Mainh()
        {
            Alumni Al = new Alumni(DateTime.Now.ToShortDateString(),"Chemistry","Onakoya Olamide");
            Console.WriteLine(Al.Fullname);
            Console.WriteLine(Al.Graduation);
            Student se = new Student("Chemistry", "Ola Ola");
            Al.Olamide = new Person("Olamide Badoo");
            Console.WriteLine(se.Olamide);
            Console.WriteLine(Al.Olamide);
            Console.WriteLine(Al.Fullname);

            //string s = "geeks";
            //var a1 = typeof(string);
            //var a2 = s.GetType();
            //Console.WriteLine($"{a1},\n {a2}");

            //object obj = "Hello";
            //Type b1 = typeof(object);
            //Type b2 = obj.GetType();
            //Console.WriteLine($"{b1}, \n {b2}");
            //Console.Read();
            Console.ReadLine();
            //Demo2 fo = new Demo2();
            //fo.Test2();fo.Test3();fo.Test5();
            //Console.ReadLine();
            //Program d = new Program();
            //d.
        }
    }
    class Person
    {
        public Person(string fullname)
        {
            this.Fullname = fullname;
        }
        public string Fullname { get; set; }

        public override string ToString()
        {
            return this.Fullname;
        }
    }
    class Student:Person
    {
        public Student(string course,string fullname):base(fullname)
        {
            this.Course = course;
            
        }
        public string Course { get; set; }
        public Person Olamide { get; set; }
    }

    class Alumni:Student
    {
        public Alumni(string graduation,string course,string fullname ):base(course,fullname)
        {
            this.Graduation = graduation;
        }
        public string Graduation { get; set; }
    }
}
