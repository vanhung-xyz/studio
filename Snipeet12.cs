using Snippet9.Vehicle.Jeep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Snippet9
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string category;

                public Category()
                {
                    category = "Multi Utility Vehicle";
                }

                public void Display()
                {
                    Console.WriteLine("JeepCategory: " + category);
                }
            }
        }
    }

    class Automobile
    {
        static void Main(string[] args)
        {
            Vehicle.Jeep.Category objCat = new Vehicle.Jeep.Category();
            objCat.Display();
            Vehicle.Category objCategory = new Vehicle.Category();
        }
    }
}