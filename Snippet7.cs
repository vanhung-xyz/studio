using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Snippet7
    {
        public class Category
        {
            string category;
            public Category() {
                category = "Multi Utility Vehicle";
            }
            public void Display()
            {
                Console.WriteLine("Category: " + category);
            }
        }
    }
}
