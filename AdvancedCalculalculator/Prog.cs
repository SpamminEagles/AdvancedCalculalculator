using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCalculator
{
    class Prog
    {
        public static void ThrowError(int error)
        {
            if (error < StringHandle.ERROR_CODES.Count)
            {
                Console.WriteLine(StringHandle.ERROR_CODES[error]);
            }
            else
            {
                Console.WriteLine("Error -1: Invalid error code!");
            }
        }
    }
}
