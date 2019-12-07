using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bignum
{
    class MyBigNumber
    {
        /// <summary>
        /// This is a function sum two big number
        /// </summary>
        /// <param name="numberA">The first number</param>
        /// <param name="numberB">The second number</param>
        /// <returns>result of addinf two big number</returns>
        public string sum(string numberA, string numberB)
        {
            if(numberA.Length < numberB.Length)
            {
                string swith = numberB;
                numberB = numberA;
                numberA = swith;
            }
            string result = string.Empty;
            int div;
            char temp = '0';
            for (int i = 0; i < numberA.Length; i++)
            {
                if (i < numberB.Length)
                {
                    div = (char)numberA[numberA.Length - 1 - i] + (char)numberB[numberB.Length - 1 - i] - '0' - '0' - '0' + temp;
                    if (div > 9)
                    {
                        temp = '1';
                        div = div % 10;
                    }
                    else
                        temp = '0';
                    result = div + result;
                }
                else
                {
                    if(temp=='1')
                    {
                        div = (char)numberA[numberA.Length - 1 - i]- '0' - '0' + temp;
                        if (div > 9)
                        {
                            temp = '1';
                            div = div % 10;
                        }
                        else
                            temp = '0';
                        result = div + result;
                    }
                    else
                    {
                        result = numberA.Substring(0, numberA.Length -i) + result;
                        break;
                    }
                }
            }

            if (temp == '1')
                result = temp + result;
            return result;
        }
    }
}
