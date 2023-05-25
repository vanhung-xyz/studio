using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility_Vehicle
{
    namespace Car
    {
        class Category
        {
            string category;
            public Category()
            {
                category = "LuxuryVehicle";
            }
            public void Dispaly()
            {
                Console.WriteLine("CarCategory: " + category);
            }
        }
    }
}
