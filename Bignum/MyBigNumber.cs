using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bignum
{
    class MyBigNumber
    {
        private Label lbStep;
        /// <summary>
        /// This is the constructor with lable step in to
        /// </summary>
        /// <param name="step">Label step </param>
        public MyBigNumber(Label step)
        {
            this.lbStep = step;
        }
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
                        changeStep(" rem 1");
                    }
                    else
                    {
                        changeStep(string.Empty);
                        temp = '0';
                    }
                    result = div + result;
                    changeStep(string.Concat(numberA[numberA.Length - 1 - i], " + ", numberB[numberB.Length - 1 - i], " = ", div, this.lbStep.Text));
                }
                else
                {
                    if(temp=='1')
                    {
                        div = (char)numberA[numberA.Length - 1 - i] + (char)numberB[numberB.Length - 1 - i] - '0' - '0' - '0' + temp;
                        if (div > 9)
                        {
                            temp = '1';
                            div = div % 10;
                            changeStep(" rem 1");
                        }
                        else
                        {
                            changeStep(string.Empty);
                            temp = '0';
                        }
                        result = div + result;
                        changeStep(string.Concat(numberA[numberA.Length - 1 - i], " + ", numberB[numberB.Length - 1 - i], " = ", div, this.lbStep.Text));
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

        /// <summary>
        /// Show the step to the lable 
        /// </summary>
        /// <param name="message"></param>
        private void changeStep(String message)
        {
          lbStep.Text = message;
        }

    }
}
