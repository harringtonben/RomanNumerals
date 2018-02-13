using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = true;
            while (run)
            {
                Console.WriteLine("Enter a whole number between 1 and 4000 and press enter and I will give you it's roman numeral equivalent. Type quit and hit enter to exit.");
                var userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    run = false;
                    break;
                }
                var numeralMe = new Numerals();
                var numeralOutput = numeralMe.ConvertNumber(int.Parse(userInput));
                Console.WriteLine($"The roman numeral for {userInput} is {numeralOutput}"); 
            }
        }
    }
}
