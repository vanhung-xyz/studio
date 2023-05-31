using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithi2
{
    class Animal
    {
        protected string name;
        protected int weight;

        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }
    }
}
