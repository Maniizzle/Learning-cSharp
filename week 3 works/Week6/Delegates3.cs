using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Delegates3
    {
    }
    public delegate T SaveDelegate<T>(Data data);
    public partial class Program
    {
        public static void Mainyt()
        {

            Subjects sub = new Subjects();
            SaveDelegate<int> savedelegate = sub.SaveCourse;
            savedelegate += Students.SaveStudent;
            var data = new Data
            {
                Title = "Testing data"
            };

            savedelegate(data);
            Console.WriteLine("===============");
            savedelegate -= Students.SaveStudent;
            savedelegate(data);
        }
    }
    public class Data
    {
        public string Title { get; set; }
        public override string ToString() => $"{this.Title}";
    }
    public class Subjects
    {
        public int SaveCourse(Data data)
        {
            Console.WriteLine($"{nameof(SaveCourse)} method was called and {data} was passed.");
            data.Title = "New Data";
            return 1;
        }
    }
    public class Students
    {
        public static int SaveStudent(Data data)
        {
            Console.WriteLine($"{nameof(SaveStudent)} method was called and {data} was passed.");
            return 2;
        }
    }
}
