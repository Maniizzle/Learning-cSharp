using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week
{
    //class Delegates
   // {
 //   }
   // public delegate H Function<T, H>(T t);
    //public delegate H Function<T, T2, H>(T t, T2 t2);
    public partial class Program
    {
        public static void Mainu()
        {
            Action<int, int> action = PersonFilter.ActionFilter;
            /* */
            List<Person> people = new List<Person>();
            people.Add(new Person() { LastName = "Prolifik", FirstName = "Lexzy" });
            people.Add(new Person() { LastName = null, FirstName = "Hunter" });
            people.Add(new Person() { LastName = "scott", FirstName = "Allen" });
            people.Add(new Person() { LastName = "John", FirstName = "Newman" });
            var filterList = people.Where(PersonFilter.ScottFilter);
            foreach (var person in filterList)
            {
                Console.WriteLine(person);
            }
        }
    }
    public class PersonFilter
    {
        public static void ActionFilter(int i, int i2)
        {
            return;
        }
        public static bool ScottFilter(Person person)
        {
            if ("Scott".Equals(person.LastName, StringComparison.OrdinalIgnoreCase))
                return true;
            if (person.LastName.Equals("John", StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
            //return  person.LastName ==  "Scott" || person.LastName == "John";
        }
    }
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public override string ToString() => $"{this.LastName} {this.FirstName}";
    }
}
//}
