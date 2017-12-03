using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Classes
{
    public class FizzBuzzClass
    {
        /*
         * A function which takes a number and converts it into a string unless it meets the following criteria 
         * If the number is divisible by both 5 & 3 the function returns the word "FizzBuzz"
         * If the number is divisible by 3 the function returns the word "Fizz"
         * If the number is divisible by 5 the function returns the word "Buzz"
         */
        public static string PrintNumber(int input)
        {
            // throw NotImplementedException;
            //return "1";
            //return input.ToString();

            var sb = new StringBuilder();
                        
            if (input % 3 == 0)
                sb.Append("Fizz");
            if (input % 5 == 0)
                sb.Append("Buzz");

            if (sb.Length==0)
                return input.ToString();

            return sb.ToString();
        }
    }
}
