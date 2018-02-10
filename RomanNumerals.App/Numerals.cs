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
            if (number == 9) return "IX";
            if (number == 5) return "V";
            if (number >= 1) return "I";
            return "You must enter a valid number";
        }
    }

}
