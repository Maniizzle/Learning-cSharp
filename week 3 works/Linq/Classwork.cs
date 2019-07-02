using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWriters { 
    public enum CastCompareType
    {
        FirstName, LastName, Age
    }
   public class CastComparer : IComparer<Cast>
       {
        internal readonly CastCompareType _compareType;
        
        public CastComparer(CastCompareType compareType) 
        { 
            _compareType = compareType;
        }
        public int Compare(Cast x, Cast y)
        {
            switch (_compareType)
            {
                case CastCompareType.Age:

                    return (y.Age < x.Age) ? x.Age.CompareTo(y.Age) : (x.Age == y.Age) ? x.LastName.CompareTo(y.LastName) : -1;

                case CastCompareType.LastName:
                    return y.LastName != x.LastName ? x.LastName.CompareTo(y.LastName): x.Age.CompareTo(y.Age) ;

                case CastCompareType.FirstName:
                    return (x.FirstName!=y.FirstName)? x.FirstName.CompareTo(y.FirstName):y.Age.CompareTo(x.Age);

                default:
                   return 1;
                    //case PersonCompareType.FirstName:
                    //  return string.Compare()
            }

        }
    }
    public class Cast
    { 
        public Cast()
        {

        }
            public string LastName { get; set; }
            public string FirstName { get; set; }
             public int Age { get; set; }

        public override string ToString()
        {  
               return $"{Age} {LastName} {FirstName} ";
            
           
        }
        
        //public int CompareTo(Cast other)
        //{
        //   // if (other == null) return 1;
        //    if (Age == other.Age)
        //    {
        //    return other.LastName.CompareTo(this.LastName);
        //            }
        //    // int result= Age > other.Age?1:0;
        //    return other.Age.CompareTo(this.Age);
        //    //if (result == 0)
        //    //{
        //       // result = string.Compare(LastName, other.LastName);
        //    //}
        //    //return result;
        //}
        ////public string override
    }

   
}
