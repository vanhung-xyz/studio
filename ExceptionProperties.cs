using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet17
{
    class ExceptionProperties
    {
        static void Main(string[] args)
        {
            byte numOne = 200;
            byte numTow = 5;

            byte result = 0;
            try
            {
                result = checked((byte)(numOne * numTow));
                Console.WriteLine("Result ={0}", result);
            }
            catch (OverflowException objEx)
            {
                Console.WriteLine("Message : {0}", objEx.Message);
                Console.WriteLine("Source : {0}", objEx.Source);
                Console.WriteLine("TargetSite : {0}", objEx.TargetSite);
                Console.WriteLine("StackTrace : {0}", objEx.StackTrace);
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: {0}", objEx);
                Console.ReadLine();
            }
        }
    }
}
