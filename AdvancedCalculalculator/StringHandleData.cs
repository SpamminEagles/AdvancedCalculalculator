using System.Collections.Generic;

namespace AdvancedCalculator
{
    public partial class StringHandle
    {
        public static readonly char[] OPERATORS = { '+', '-', 'x', '/', 'q', 'd', '^', '!' };
        public static readonly char[] NUMBERS = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static readonly char[] PARANTHESES = { '(', ')' };
        public static readonly Dictionary<int, string> ERROR_CODES = new Dictionary<int, string>
        {
            //Multiple operators after 
            {0, "Error 0: Operator overflow" },

            //Not closed/Not opened parantheses
            {1, "Error 1: Broken parantheses" }
        };
    }
}
