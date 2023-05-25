using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Snippet15
{
    class Students
    {
        string[] namas = { "James", "John", "Alexander" };
        static void Main(string[] args)
        {
            Students objStudents  = new Students();
            try
            {
                objStudents.namas[4] = "Michael";
            }
            catch(Exception objException)
            {
                Console.WriteLine("Error: " + objException);
            }
        }
    }
}
