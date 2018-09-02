using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCalculator
{
    class Prog
    {
        public static readonly Dictionary<int, string> ERROR_CODES = new Dictionary<int, string>
        {
            //Multiple operators after 
            {0, "Error 0: Operator overflow" },

            //Not closed/Not opened parantheses
            {1, "Error 1: Broken parantheses" },

            //Speaks for itself
            {2, "Error 2: Invalid character" },

            {3, "Error 3: MathError: Division by zero"},

            {4, "Error 4: MathError: Square root of negative"},

            {5, "Error 5: MathError: Reciprocal of zero"},

            {6, "Error 6: MathError: Factorial of negative integer"},

            {7, "Error 7: MathError: Factorial of non-integer"}

        };

        public static void ThrowError(int error)
        {
            if (error < ERROR_CODES.Count)
            {
                Console.WriteLine(ERROR_CODES[error]);
            }
            else
            {
                Console.WriteLine("Error -1: Invalid error code!");
            }
        }
    }
}
