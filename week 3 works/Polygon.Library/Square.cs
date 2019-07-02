using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Library
{
    class Square : ConcretePolygon
    {
        public Square(int length) : base(4, length)
        {

        }
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }

    class Triangle : ConcretePolygon
    {
        public Triangle(int length) : base(3, length)
        {

        }
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }

        public class Octagon : IRegularPolygon
        {
            public int NumberofSides { get; set; }
            public int SideLength { get; set; }
            
            public Octagon(int length)
            {
                NumberofSides = 8;
                SideLength = length;

            }
            public double GetPerimeter()
            {
                return NumberofSides * SideLength;

            }
            public double GetArea()
            {
                return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));

            }

        }
    }

}