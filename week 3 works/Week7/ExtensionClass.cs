using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
   public static class ExtensionClass
    {

        public static void Mainr()
        {
            string number = "08065993324";
            var maskedNumber = number.ToMask(3, number.Length - 3);
            Console.WriteLine(maskedNumber);
        }
    

    
   

        public static string ToMask(this string value, int startIndex, int length
         , char maskTemplate = '*')
        {
            //var temp = value.Substring(startIndex, length);
            var temp2 = value.Remove(startIndex, length);
            var v = temp2.PadRight(value.Length, maskTemplate);//.Replace(temp, maskTemplate.ToString());
            return v;
        }
        //public static string ToMask(this string value,int startIndex,int length,char maskTemplate='*')
        //{
        //    string g = "08146458222";
        //    g.Remove(startIndex,length);
        //    g.PadRight(11, maskTemplate);
        //}
    }
}
