using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Delegates2
    {
    }

    public delegate void SaveDelegate();
    public partial class Program
    {
        public static void Mainw()
        {
            Subject sub = new Subject();
            SaveDelegate savedelegate = sub.SaveCourse;
            savedelegate += Student.SaveStudent;
            savedelegate();
            Console.WriteLine("===============");
            savedelegate -= Student.SaveStudent;
            savedelegate();
        }
    }
    public class Subject
    {
        public void SaveCourse()
        {
            Console.WriteLine($"{nameof(SaveCourse)} method was called.");
            return ;
        }
    }
    public class Student
    {
        public static void SaveStudent()
        {
            Console.WriteLine($"{nameof(SaveStudent)} method was called.");
            return ;
        }
    }
}
