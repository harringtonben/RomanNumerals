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
                if (number >= 10)
                {
                    numeralReturn += "X";
                    number -= 10;
                }
                if (number == 9)
                {
                    numeralReturn += "IX";
                    number -= 9;
                }
                if (number == 5)
                {
                    numeralReturn += "V";
                    number -= 5;
                }
                if (number >= 1)
                {
                    numeralReturn += "I";
                    number -= 1;
                }
            }

            return numeralReturn;
        }
    }

}
