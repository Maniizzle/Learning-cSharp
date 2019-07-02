using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    public abstract class ConcretePolygon
    {
        public int NumberofSides { get; set; }
        public int SideLength { get; set; }

        public ConcretePolygon(int sides,int length)
        {
            NumberofSides = sides;
            SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberofSides * SideLength;
        }
        public abstract double GetArea();
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class ConcretePolygons
    {
        public int NumberofSides { get; set; }
        public int SideLength { get; set; }

        public ConcretePolygons(int sides, int length)
        {
            NumberofSides = sides;
            SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberofSides * SideLength;
        }
        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
        public interface IRegularPolygon
        {
            int NumberofSides { get; set; }
            int  SideLength { get; set; }
            double GetPerimeter();
            double GetArea();

        }

    //CRUD REPOSITORY(CREATE READ UPDATE DELETE)
    public interface iPersonRepository
    {
        void AddPerson(Person newPerson);
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
        void UpdatePerson(int id, Person updatedPerson);
        void DeletePerson(int id);
    }
    public class Person
    {

    }
    
}
