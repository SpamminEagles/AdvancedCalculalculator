using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHandle sh = new StringHandle();
            string toPass = sh.Correct(Console.ReadLine());
            //Console.WriteLine(toPass);
            if (sh.Validate(toPass))
            
            {
                string[] str = sh.Partition(toPass);
                Console.WriteLine("-------------------------");
                ArrayLib.PrintToConsole(str);
            }
            else
            {
                
            }
            Console.ReadKey();
        }
    }
}
