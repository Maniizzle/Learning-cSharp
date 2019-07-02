using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    partial class Program
    {
        
    }

    public delegate H Function<T, H>(T t);
    public delegate H Function<T, T2, H>(T t, T2 t2);
    public partial class Program
    {
        public static void Mainy()
        {
            Func<int, int, bool> func = ProductList.Where;
        }
    }

    public class ProductList
    {
        public static bool Where(int i, int i2)
        {
            return false;
        }
    }

    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
