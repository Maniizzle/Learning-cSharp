using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    public class  Program
    {
        static void Maink(string[] args)
        {
            Console.WriteLine(numbercheck(78768));
            Console.ReadLine();
        }
        
        static string numbercheck(long num)
        {
            string ans = "";
            if (num < 1000000000)
            {
                int num1 = (int)num;
                if (num >= 0 && num < 100)
                    ans += below100(num1);
                if (num >= 100 && num < 1000)
                    ans += Hundreds(num1);
                if (num >= 1000 && num < 1000000)
                    ans += Thousand(num1);
                if (num >= 1000000 && num < 1000000000)
                    ans += Million(num1);
            }
            if (num >= 1000000000 && num < 1000000000000)
                ans += Billion(num);
            if (num >= 1000000000000 && num < 1000000000000000)
                ans += Trillion(num);

            return ans;
        }



        static string below100(int n)
        {
            string ans = "";
            if (n >=0 && n < 21)
                ans += digit[n];
            else
            {
                int div = n / 10;
                int rem = n % 10;
                ans += tensDigits[(n / 10 - 2)] + " " + digit[rem];
            }
            return ans;
        }
        static string Hundreds(int n)
        {
            string ans = "";
            int div = n / 100;
            int rem = n % 100;
            if (rem==0)
            ans += digit[div] + " " + hundredDigits[0];
            else
            ans += digit[div] +" "+ hundredDigits[0] + " and " + below100(rem);
            return ans;
        }

        static string Thousand(int n)
        {
            string ans = "";
            int div = n / 1000;
            int rem = n % 1000;
            ans = numbercheck(div) + " " + hundredDigits[1];
            if (rem != 0)
            { if (rem < 100)
                    ans += " and " + numbercheck(rem);
              else
                    ans += " " + numbercheck(rem); }
            //if (div > 99)
            //    ans += Hundreds(div) + " "+ hundredDigits[1] + " " + numbercheck(rem);
            //else
            //    ans += below100(div) +" " +hundredDigits[1] + " " + numbercheck(rem);


            return ans;

        }
        static string Million(int n)
        {
            string ans = "";
            int div = n / 1000000;
            int rem = n % 1000000;
            if (div > 99)
                ans += Hundreds(div) + " " + hundredDigits[2] + " " + numbercheck(rem);
            else
                ans += below100(div) + " " + hundredDigits[2] + " " + numbercheck(rem);

            return ans;
        }
        static string Billion(long n)
        {
            string ans = "";
            int div = (int)(n / 1000000000);
            int rem = (int)(n % 1000000000);
            if (div > 99)
                ans += Hundreds(div) + " " + hundredDigits[3] + " " + numbercheck(rem);
            else
                ans += below100(div) + " " + hundredDigits[3] + " " + numbercheck(rem);


            return ans;
        }
        static string Trillion(long n)
        {
            string ans = "";
            int div = (int)(n / 1000000000000);
            long rem = (long)(n % 1000000000000);
            if (div > 99)
                ans += Hundreds(div) + " " + hundredDigits[4] + " " + numbercheck(rem);
            else
                ans += below100(div) + " " + hundredDigits[4] + " " + numbercheck(rem);


            return ans;
        }

        static string[] digit = {"zero","one","two","three","four","five","six","seven","eight" ,"nine","ten","eleven","twelve","thirteen","fourteen"
            ,"fifteen","sixteen", "swventeen","eighteen","nineteen","twenty"};

        static string[] tensDigits = { "twenty", "thirty", "forty", "fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] hundredDigits = { "Hundred", "Thousand", "Million", "Billion", "Trillion" };
    }

}