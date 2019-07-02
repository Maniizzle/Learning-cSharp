using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWeek3
{
    public class Data
    {
    }

    public class DataManager
    {

        public virtual void SaveRecord(Data data)
        {
            Console.WriteLine("DataManager save record was called");
        }
    }

    public class StudentDataManager : DataManager
    {
        public override void SaveRecord(Data data)
        {
            //base.SaveRecord(data);
            Console.WriteLine("StudentDataManager saved record was called");

        }
    }

    public class CourseDataManager: DataManager
    {

    }
    public partial class Program
    {

        public static void Maing()
        {
            StudentDataManager dataMgr = new StudentDataManager();
            dataMgr.SaveRecord(new Data());
            // dataMgr = new CourseDataManager();


            Console.ReadLine();
        }
    }


    public interface ICompressible
    {
        void Decompress();
        void Compress();
        void Read();
    }

    public interface IStorage : ICompressible
    {
        void Write();
        void Read();
    }
    public class HardDrive : IStorage
    {
       public void Write()
        {

        }
        public void Read()
        {

        }
        public void Decompress()
        {

        }
        public void Compress()
        {

        }

        void IStorage.Read()
        {

        }

        public class OneDrive:IStorage
        {public void Write()
            {

            }
            public void Read()
            {

            }
            public void Decompress()
            {

            }
            public void Compress()
            {

            }

            void ICompressible.Read()
            {

            }

        }
    } 

}
