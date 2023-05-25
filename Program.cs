﻿using Automotive.Vehicle.Jeep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
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
        class Automobile
        {
            static void Main(string[] args)
            {
                Category objCat = new Category();
                objCat.Display();

                Utility_Vehicle.Category objCategory = new Utility_Vehicle.Category();
                objCategory.Display();
            }
        }
    }
}
