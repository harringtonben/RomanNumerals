using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.App
{
    public class Numerals
    {
        public string ConvertNumber(int number)
        {
            var numeralReturn = "";

            while (number > 0)
            {
                if (number >= 1000)
                {
                    numeralReturn += "M";
                    number -= 1000;
                    continue;
                }
                if (number >= 900)
                {
                    numeralReturn += "CM";
                    number -= 900;
                    continue;
                }
                if (number >= 500)
                {
                    numeralReturn += "D";
                    number -= 500;
                    continue;
                }
                if (number >= 100)
                {
                    numeralReturn += "C";
                    number -= 100;
                    continue;
                }
                if (number >= 90)
                {
                    numeralReturn += "XC";
                    number -= 90;
                    continue;
                }
                if (number >= 50)
                {
                    numeralReturn += "L";
                    number -= 50;
                    continue;
                }
                if (number >= 40)
                {
                    numeralReturn += "XL";
                    number -= 40;
                    continue;
                }
                if (number >= 10)
                {
                    numeralReturn += "X";
                    number -= 10;
                    continue;
                }
                if (number >= 9)
                {
                    numeralReturn += "IX";
                    number -= 9;
                    continue;
                }
                if (number >= 5)
                {
                    numeralReturn += "V";
                    number -= 5;
                    continue;
                }
                if (number >= 4)
                {
                    numeralReturn += "IV";
                    number -= 4;
                    continue;
                }
                if (number >= 1)
                {
                    numeralReturn += "I";
                    number -= 1;
                    continue;
                }
            }

            return numeralReturn;
        }
    }

}
