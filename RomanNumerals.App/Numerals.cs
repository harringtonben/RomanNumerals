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
            if (number >= 1) return "I";
            return "You must enter a valid number";
        }
    }

}
