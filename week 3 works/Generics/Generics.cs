using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWeek3
{
    class Generics
    {

    }
    public interface IManager<T1,T2>
    {
        void SaveRecord(T1 data,T2 datas);
    }

    public class DataManager<T1,T2>:IManager<T1,T2>
    {
        
        public void SaveRecord(T1 data,T2 datas)
        {
            //default(T1); this returns the type T1
           // return data;
        }
    }
    public class Course<C>
    {
        public C Id { get; set; }
        public string Title { get; set; }
        public int Unit { get; set; }
    }
    public class Topic
    {

    }
    public class Students
    { }
        public partial class Program
        {
            public static void Mains()
            {
            shere ds = new shere(3);
            
            ds.Display();
           //// ds.x = 20;
           // Console.WriteLine("Field dog is " + dog.x);
           //// dog.X = 25;
           // Console.WriteLine("Properties dog is " + dog.X);
           // Console.WriteLine("New Field dog is " + dog.x);
           // Console.ReadLine();


            var courseManager = new DataManager<Students,Course<int>>();
                var course = new Course<int>();
            var gu = new Students();
            courseManager.SaveRecord(new Students(),course);
            }
        }
}