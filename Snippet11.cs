using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet9
{
    class Snippet11
    {
        static void Main(string[] args)
        {
            Emp.Employees objEmp = new Emp.Employees();
            objEmp.EmpName = "Peter";
            Console.WriteLine("EmployeeName: " + objEmp.EmpName);
        }
    }
}