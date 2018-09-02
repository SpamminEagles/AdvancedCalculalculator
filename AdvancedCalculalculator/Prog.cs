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
            {2, "Error 2: Invalid character" }
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
