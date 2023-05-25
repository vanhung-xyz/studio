using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Snippet6
    {
        public class SpareParts
        {
            string spareName;
            public SpareParts() {
                spareName = "GearBox";
            }
            public void Display()
            {
                Console.WriteLine("SparePartname: " + spareName);
            }
        }
    }
}
