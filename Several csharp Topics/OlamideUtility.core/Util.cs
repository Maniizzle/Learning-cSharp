using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlamideUtility.core
{
    public static class OlaUtility
    {
        
        public static string BaseToBase(string Number, int TheNumbersBase, int TheNewBase)
        {
           
            ulong decimalNumber = BaseToDecimal(Number, TheNumbersBase);
            return DecimalToBase(decimalNumber, TheNewBase);


        }

        static string DecimalToBase(ulong decimalInput, int baseNumber)
        {
            string hexMap = "0123456789ABCDEF";
            string joinedNewNumber = "";
        Restart:
            if (decimalInput > 0)
            {
                int newNumber = (int) (decimalInput % (ulong)baseNumber);
                decimalInput = decimalInput / (ulong)baseNumber;
                char newNumberString = hexMap[newNumber];
                joinedNewNumber = newNumberString + joinedNewNumber;
            }

            else
            {
                return joinedNewNumber;
            }
            goto Restart;

        }


        static ulong BaseToDecimal(string inputNum, int theBase)
        {
            string newInput = inputNum.ToUpper();
            string hexMap = "0123456789ABCDEF";
            ulong decimalValue = 0;
            int power = inputNum.Length;

            for (int i = 0; i < inputNum.Length; i++)
            {
                string eachValue = newInput.Substring(i, 1);
                int Value = hexMap.IndexOf(eachValue);
                decimalValue += (ulong)Value * (ulong)Math.Pow(theBase, power - 1);
                power--;
            }
            return decimalValue;
        }



        static string[] digit = {"Zero ","One","Two","Three","Four","Five","Six","Seven","Eight" ,"Nine","Ten","Eleven","Twelve","Thirteen","Fourteen"
            ,"Fifteen","Sixteen", "Seventeen","Eighteen","Nineteen","Twenty"};

        static string[] tensDigits = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] hundredDigits = { "Hundred", "Thousand", "Million", "Billion", "Trillion" };

        /// <summary>
        /// Converts a given number to words. E.g; 123 = One hundred and Twenty three.
        /// </summary>
        /// <param name="num">Number to convert to word</param>
        /// <returns>a textual representation of the given number</returns>
        public static string ConvertNumberToWords(long num)
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
            if (n >= 0 && n < 21)
                ans += digit[n];
            else
            {
                int div = n / 10;
                int rem = n % 10;
                ans += tensDigits[(n / 10 - 2)];
                if (rem!=0)
                ans +=  " " + digit[rem];
            }
            return ans;
        }
        static string Hundreds(int n)
        {
            string ans = "";
            int div = n / 100;
            int rem = n % 100;
            if (rem == 0)
                ans += digit[div] + " " + hundredDigits[0];
            else
                ans += digit[div] + " " + hundredDigits[0] + " and " + below100(rem);
            return ans;
        }

         static string Thousand(int n)
        {
            string ans = "";
            int div = n / 1000;
            int rem = n % 1000;
            ans = ConvertNumberToWords(div) + " " + hundredDigits[1];
            if (rem != 0)
            {
                if (rem < 100)
                    ans += " and " + ConvertNumberToWords(rem);
                else
                    ans += ", " + ConvertNumberToWords(rem);
                }
            return ans;
            //if (div > 99)
            //    ans += Hundreds(div) + " " + hundredDigits[1] + " " + numbercheck(rem);
            //else
            //    ans += below100(div) + " " + hundredDigits[1] + " " + numbercheck(rem);

        }
        static string Million(int n)
        {
            string ans = "";
            int div = n / 1000000;
            int rem = n % 1000000;
            ans = ConvertNumberToWords(div) + " " + hundredDigits[2];
            if (rem != 0)
            {
                if (rem < 100)
                    ans += " and " + ConvertNumberToWords(rem);
                else
                    ans += ", " + ConvertNumberToWords(rem);
            }
        //    if (div > 99)
        //        ans += Hundreds(div) + " " + hundredDigits[2] + " " + numbercheck(rem);
        //    else
        //        ans += below100(div) + " " + hundredDigits[2] + " " + numbercheck(rem);

            return ans;
        }
         static string Billion(long n)
        {
            string ans = "";
            int div = (int)(n / 1000000000);
            int rem = (int)(n % 1000000000);
            ans = ConvertNumberToWords(div) + " " + hundredDigits[3];
            if (rem != 0)
            {
                if (rem < 100)
                    ans += " and " + ConvertNumberToWords(rem);
                else
                    ans += ", " + ConvertNumberToWords(rem);
            }
            //if (div > 99)
            //    ans += Hundreds(div) + " " + hundredDigits[3] + " " + numbercheck(rem);
            //else
            //    ans += below100(div) + " " + hundredDigits[3] + " " + numbercheck(rem);


            return ans;
        }
         static string Trillion(long n)
        {
            string ans = "";
            int div = (int)(n / 1000000000000);
            long rem = (long)(n % 1000000000000);
            ans = ConvertNumberToWords(div) + " " + hundredDigits[4];
            if (rem != 0)
            {
                if (rem < 100)
                    ans += " and " + ConvertNumberToWords(rem);
                else
                    ans += ", " + ConvertNumberToWords(rem);
            }
            //if (div > 99)
            //    ans += Hundreds(div) + " " + hundredDigits[4] + " " + numbercheck(rem);
            //else
            //    ans += below100(div) + " " + hundredDigits[4] + " " + numbercheck(rem);


            return ans;
        }

    }
}
