using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet15
{
    class DivisionError
    {
        static void Main(string[] args)
        {
            int numOne = 133;
            int numTow = 0;
            int result;
            try
            {
                result = numOne / numTow;
            }
            catch (DivideByZeroException objDivede) {
                Console.WriteLine("Exception caught: " + objDivede);
        }
    }
}
