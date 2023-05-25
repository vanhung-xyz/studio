using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session9.Snippet6;
using static Session9.Snippet7;

namespace Session9
{
    class Snippet8
    {
        static  void Main(string[] args)
        {
            Category objCategory = new Category();
            SpareParts objSpare = new SpareParts();
            objCategory.Display();
            objSpare.Display();
            Console.ReadLine();
        }
    }
}
