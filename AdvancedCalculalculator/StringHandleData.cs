using System.Collections.Generic;

namespace AdvancedCalculator
{
    public partial class StringHandle
    {
        public static readonly char[] OPERATORS = { '+', '-', 'x', '/', 'q', 'd', '^', '!' };
        public static readonly char[] NUMBERS = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static readonly char[] PARANTHESES = { '(', ')' };
        


        enum PartitionStatus { None,  Number, Paranthese};
        public enum ElementType { Number, Operator, Parantheses, None};
    }
}
