using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(500, "lion");
            Tiger tiger = new Tiger(250, "tiger");

            lion.Show();
            tiger.Show();
            Console.ReadLine();
        }
    }
}